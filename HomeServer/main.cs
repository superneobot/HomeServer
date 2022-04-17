using AngleSharp;
using AngleSharp.Io;
using Newtonsoft.Json;
using NReco.VideoInfo;
using StreamServer;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vlc.DotNet.Core;
using Application = System.Windows.Forms.Application;

namespace HomeServer
{
    public partial class mainform : Form
    {
        #region Переменные сервера
        //
        HomeServer server;
        public IPAddress ipAddress;
        public int port;
        public int max_connection;
        public string content_path;
        public string local_ip;
        public string remote_ip;
        byte[] address { get; set; }
        public bool autostart = Properties.Settings.Default.server_autostart;
        //
        #endregion

        #region Переменные медиацентра
        public string file;
        public LibVLCSharp.Shared.LibVLC lib { get; set; }
        public VlcMediaPlayer player { get; set; }
        private object video_codec;
        private object audio_codec;
        public List<int> video_size { get; set; }
        public List<Quality> quality_list { get; set; }
        public List<int> bitrate { get; set; }
        Status status { get; set; }
        public Stream stream { get; set; }

        #endregion

        #region Переменные медиа файлов
        public string media_file_name;
        public string poster_url;
        public string wanted_film_url;
        public System.Drawing.Image poster;
        public string film_name;
        #endregion

        #region Переменные плейлиста медиацентра
        public List<Item> items { get; set; }
        public List<string> film_list { get; set; }
        public List<Movie> movies { get; set; }
        public int film_index_selected { get; set; }
        #endregion
        public mainform()
        {            
            InitializeComponent();
            #region Параметры сервера
            //
            server = new HomeServer();
            address = new byte[4];
            address[0] = (byte)ip1.Value;
            address[1] = (byte)ip2.Value;
            address[2] = (byte)ip3.Value;
            address[3] = (byte)ip4.Value;
            ipAddress = new IPAddress(address);
            port = (int)server_port.Value;
            max_connection = 10;
            content_path = Properties.Settings.Default.ServerPath;
            //
            #endregion
            #region Параметры медиацентра
            var library = new DirectoryInfo(Path.Combine(Application.StartupPath, "libvlc", IntPtr.Size == 4 ? "win-x86" : "win-x64"));
            player = new VlcMediaPlayer(library);

            video_size = new List<int>();

            player.Opening += Media_Opening;
            player.Playing += Media_Playing;
            player.Stopped += Player_Stopped;
            player.TimeChanged += Fhd_player_TimeChanged;
            player.LengthChanged += Player_LengthChanged;
            #endregion
            #region Параметры переменных медиафайлов
            poster = null;
            #endregion
            #region Параметры плейлиста медиацентра
            movies = new List<Movie>();
            items = new List<Item>();
            film_list = new List<string>();
            #endregion
        }

        private void mainform_Load(object sender, EventArgs e)
        {
            #region Настройки сервера
            autostart = Properties.Settings.Default.server_autostart;
            autostart_server.Checked = autostart;
            server_path.Text = Properties.Settings.Default.ServerPath;
            // Получение имени компьютера.
            String host = System.Net.Dns.GetHostName();
            // Получение ip-адреса.
            System.Net.IPAddress ip = Dns.GetHostByName(host).AddressList[0];
            // Показ адреса в label'е.
            label1.Text = $"Локальный IP адрес: {ip}";
            local_ip = ip.ToString();
            label2.Text = $"Внешний IP адрес: {GetComputer_InternetIP()}";
            remote_ip = GetComputer_InternetIP();
            label3.Text = $"Адрес веб-сервера: {ipAddress} порт {port}";
            timer.Start();
            linkLabel1.Text = $"http://{address[0]}.{address[1]}.{address[2]}.{address[3]}";

            if (autostart)
            {
                StartServer();
            }
            #endregion

            status = Status.Idle;
            open_file.Focus();
            Width = 390;
            Height = 310;
        }

        #region Веб-сервер
        private string GetComputer_InternetIP()
        {
            string pubIp = new System.Net.WebClient().DownloadString("https://api.ipify.org");
            return pubIp;
        }

        private void start_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void StartServer()
        {
            if (!server.running)
            {
                ip1.Enabled = false;
                ip2.Enabled = false;
                ip3.Enabled = false;
                ip4.Enabled = false;
                server_port.Enabled = false;
                server.start(ipAddress, port, max_connection, content_path);
                start.Text = "Стоп";
                web_server_status.Text = "Веб-сервер запущен";
            }
            else
            {
                ip1.Enabled = true;
                ip2.Enabled = true;
                ip3.Enabled = true;
                ip4.Enabled = true;
                server_port.Enabled = true;
                start.Text = "Старт";
                server.stop();
                web_server_status.Text = "Веб-сервер остановлен";
            }
        }

        private void select_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    content_path = folderBrowserDialog.SelectedPath + "\\";
                    Properties.Settings.Default.ServerPath = content_path;
                    Properties.Settings.Default.Save();
                    server_path.Text = content_path;
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            label3.Text = $"Адрес веб-сервера: {address[0]}.{address[1]}.{address[2]}.{address[3]} порт {port}";
        }

        private void ip1_ValueChanged(object sender, EventArgs e)
        {
            address[0] = (byte)ip1.Value;
        }

        private void ip2_ValueChanged(object sender, EventArgs e)
        {
            address[1] = (byte)ip2.Value;
        }

        private void ip3_ValueChanged(object sender, EventArgs e)
        {
            address[2] = (byte)ip3.Value;
        }

        private void ip4_ValueChanged(object sender, EventArgs e)
        {
            address[3] = (byte)ip4.Value;
        }

        private void server_port_ValueChanged(object sender, EventArgs e)
        {
            port = (int)server_port.Value;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (server.running)
                Process.Start(linkLabel1.Text, "");
        }

        private void open_local_path_Click(object sender, EventArgs e)
        {
            if (content_path != String.Empty)
                Process.Start(content_path);
        }



        private void autostart_server_Click(object sender, EventArgs e)
        {
            if (!autostart)
            {
                autostart = true;
                autostart_server.Checked = true;
                Properties.Settings.Default.server_autostart = autostart_server.Checked;
                Properties.Settings.Default.Save();
            }
            else
            {
                autostart = false;
                autostart_server.Checked = false;
                Properties.Settings.Default.server_autostart = autostart_server.Checked;
                Properties.Settings.Default.Save();
            }
        }

        #endregion

        #region players_status
        private void Player_LengthChanged(object sender, VlcMediaPlayerLengthChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                elapsed.Text = TimeSpan.FromMilliseconds(e.NewLength).ToString(@"hh\:mm\:ss");
                progress.Maximum = (int)e.NewLength;
            }));
        }

        private void Fhd_player_TimeChanged(object sender, VlcMediaPlayerTimeChangedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                time.Text = TimeSpan.FromMilliseconds((int)player.Time).ToString(@"hh\:mm\:ss");
                progress.Value = (int)e.NewTime;
            }));
        }

        private void Player_Stopped(object sender, VlcMediaPlayerStoppedEventArgs e)
        {
            status = Status.Idle;
            Invoke(new Action(() =>
            {
                time.Text = "00:00:00";
                elapsed.Text = "00:00:00";
            }));
        }

        private void Media_Playing(object sender, VlcMediaPlayerPlayingEventArgs e)
        {
            status = Status.Play;
        }

        private void Media_Opening(object sender, VlcMediaPlayerOpeningEventArgs e)
        {
            status = Status.Starting;
        }
        #endregion

        #region Медиа центр
        private void mainform_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (e.CloseReason == CloseReason.UserClosing)
            //{
            //    e.Cancel = false;
            //    //  server.stop();
            //   // Hide();
            //}
            Process.GetCurrentProcess().Kill();
        }

        private void open_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "MKV *.mkv Mp4 *.mp4 AVI *.avi|*.mkv;*.mp4;*.avi";
                //op.Multiselect = true;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    file = op.FileName;
                    file_cap.Text = $"Filename: {Path.GetFileName(op.FileName)}";
                    status = Status.Ready;
                    VideoSize(file);
                    GetQuality(file);
                    // GetPoster(file);
                    quality.Enabled = true;
                    start_mc.Enabled = true;
                    reset.Enabled = true;
                }
            }
        }

        public void start_mc_Click(object sender, EventArgs e)
        {
            if (quality.SelectedIndex > -1 & brate.SelectedIndex > -1)
            {
                pl_timer.Start();
                int index = quality.SelectedIndex;
                quality_list[index].Url = address_mediacenter.Text;
                Initialize_server(player, file, quality_list[index].param);
                stop_mc.Enabled = true;
                marq.Text = "[ >>> ]";
            }
            else
            {

            }
        }

        private void stop_mc_Click(object sender, EventArgs e)
        {
            player.Stop();
            pl_timer.Stop();
            mc_status.Text = "Медиацентр остановлен";
            stop_mc.Enabled = false;
            marq.Text = "[ | | | ]";
            progress.Value = 0;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            player.Stop();
            pl_timer.Stop();
            bitrate.Clear();
            quality_list.Clear();
            quality.Items.Clear();
            brate.Items.Clear();
            player.ResetMedia();
            start_mc.Enabled = false;
            quality.Enabled = false;
            brate.Enabled = false;
            stop_mc.Enabled = false;
            file = null;
            file_cap.Text = "Filename: ";
            init_height.Text = "Stream height: ";
            init_width.Text = "Stream width: ";
            width_cap.Text = "Original width: ";
            height_cap.Text = "Origibal height: ";
            vcodec_cap.Text = "Video Codec: ";
            acodec_cap.Text = "Audio Codec: ";
            progress.Value = 0;
        }

        public void Initialize_server(VlcMediaPlayer player, string filepath, string[] param)
        {
            stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            player.SetMedia(stream, param);
            player.Play();
        }

        public List<int> VideoSize(string filename)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Invoke(new Action(() =>
                    {
                        var file = new FFProbe();
                        var a = file.GetMediaInfo(filename);
                        var wi = a.Streams[0].Width;
                        var he = a.Streams[0].Height;

                        width_cap.Text = $"Original Width: {wi}";
                        height_cap.Text = $"Original Height: {he}";

                        video_codec = a.Streams[0].CodecName;
                        audio_codec = a.Streams[1].CodecName;

                        vcodec_cap.Text = $"Video Codec: {video_codec}";
                        acodec_cap.Text = $"Audio Codec: {audio_codec}";

                        video_size.Add(wi);
                        video_size.Add(he);
                    }));
                });
            }
            catch { }

            return video_size;
        }

        private void GetQuality(string filename)
        {
            quality_list = new List<Quality>();
            quality_list.Clear();
            quality_list.Add(new Quality(QList.HHD, "Half HD", filename));
            quality_list.Add(new Quality(QList.FHD, "Full HD", filename));
            quality_list.Add(new Quality(QList.QHD, "Quad HD", filename));
            quality_list.Add(new Quality(QList.UHD, "Ultra HD", filename));

            quality.Items.Clear();
            quality.Items.Add(quality_list[0].Name);
            quality.Items.Add(quality_list[1].Name);
            quality.Items.Add(quality_list[2].Name);
            quality.Items.Add(quality_list[3].Name);

            bitrate = new List<int>();
            bitrate.Clear();
            bitrate.Add(1000);
            bitrate.Add(2000);
            bitrate.Add(3000);
            bitrate.Add(4000);
            bitrate.Add(5000);

            brate.Items.Clear();
            brate.Items.Add(bitrate[0]);
            brate.Items.Add(bitrate[1]);
            brate.Items.Add(bitrate[2]);
            brate.Items.Add(bitrate[3]);
            brate.Items.Add(bitrate[4]);
        }

        private void quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = quality.SelectedIndex;
            init_width.Text = $"Stream width: {quality_list[index].Width}";
            init_height.Text = $"Stream height: {quality_list[index].Height}";
            brate.Enabled = true;
        }

        private void brate_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = quality.SelectedIndex;
            var sindex = brate.SelectedIndex;
            quality_list[index].Bitrate = (int)brate.Items[sindex];
        }

        private void pl_timer_Tick(object sender, EventArgs e)
        {
            Invoke(new Action(() =>
            {
                mc_status.Text = $"Медиацентр запущен - {quality_list[quality.SelectedIndex].Name} - {status}";
            }));
        }

        private void address_mediacenter_DoubleClick(object sender, EventArgs e)
        {
            if (address_mediacenter.ReadOnly == true)
            {
                address_mediacenter.ReadOnly = false;
                address_mediacenter.SelectAll();
            }
        }

        private void address_mediacenter_KeyDown(object sender, KeyEventArgs e)
        {
            if (address_mediacenter.ReadOnly == false)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (address_mediacenter.Text.Contains(@"http://"))
                    {
                        address_mediacenter.ReadOnly = true;
                    }
                    else
                    {
                        address_mediacenter.Clear();
                    }
                }
            }
        }

        #endregion

        #region Генерация данных медиа файла для веб страницы

        public async void GetPoster(string filename)
        {
            media_file_name = null;
            poster_url = null;
            film_name = null;

            filename = file;
            var ffile = new FFProbe();
            var mediafile = ffile.GetMediaInfo(filename);
            Encoding utf8 = Encoding.GetEncoding("utf-8");
            Encoding win1251 = Encoding.GetEncoding("windows-1251");
            byte[] utf8Bytes = win1251.GetBytes(mediafile.FormatTags[0].Value);
            byte[] win1251Bytes = Encoding.Convert(win1251, utf8, utf8Bytes);
            media_file_name = win1251.GetString(win1251Bytes);

            // media_file_name = String.Format(mediafile.FormatTags[0].Value, st);


            await GetFilmUrl(Path.GetFileNameWithoutExtension(filename));
            if (film_name != null)
            {
                Text = $"HomeServer - {film_name}";
            }
            else
            {
                if (media_file_name != null & !media_file_name.Contains("VirtualDub"))
                {
                    Text = $"HomeServer - {media_file_name}";
                }
                else
                {
                    Text = $"HomeServer - {Path.GetFileNameWithoutExtension(file)}";
                }
            }

            await GetPic(wanted_film_url);


            WebClient client = new WebClient();
            client.DownloadFile(poster_url, content_path + @"/poster/poster.jpg");
        }

        public async Task<string> GetFilmUrl(string film)
        {
            try
            {
                var url_arr = film.Split('(');
                var url = url_arr[0];
                var address = $"https://www.kinopoisk.ru/index.php?kp_query={url}";
                var config = Configuration.Default.WithDefaultLoader();
                var context = BrowsingContext.New(config);
                var document = await context.OpenAsync(address);
                var block = document.QuerySelector("#block_left_pad > div > div:nth-child(3) > div");
                var div = block.QuerySelector("div[class='info']");
                var wanted = div.QuerySelector("a");
                var link = wanted.GetAttribute("href");
                wanted_film_url = "https://www.kinopoisk.ru/" + link.Substring(0, link.Length - 5);
                film_name = wanted.InnerHtml;
            }
            catch { }
            return wanted_film_url;
        }

        public async Task<string> GetPic(string url)
        {
            try
            {
                var requester = new DefaultHttpRequester("Mozilla/5.0 (Windows NT 10.0; Win64; x64; rv:72.0) Gecko/20100101 Firefox/69.0");
                var config = Configuration.Default.WithDefaultLoader().With(requester);
                var address = $"https://yandex.ru/images/search?text={url} poster";
                var context = BrowsingContext.New(config);
                var document = await context.OpenAsync(address);
                var cells = document.QuerySelector(@"div[class='serp-item__preview']");

                var block = cells.QuerySelector(@"img[class='serp-item__thumb justifier__thumb']");
                // film - poster styles_root__24Jga styles_rootInDark__64LVq image styles_root__DZigd

                var link = block.GetAttribute("src");
                if (url != null)
                    poster_url = "https:" + link;
            }
            catch { MessageBox.Show("error"); }
            return poster_url;
        }

        #endregion

        #region Управление плейлистом медиацентра
        private void table_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (table.SelectedIndex < 2)
            {
                Width = 390;
                Height = 310;
            }
            else
            {
                Width = 450;
                Height = 530;
            }
        }

        private void add_files_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog op = new OpenFileDialog())
            {
                op.Filter = "MKV *.mkv Mp4 *.mp4 AVI *.avi|*.mkv;*.mp4;*.avi";
                op.Title = "Добавление фильмов в список Медиацентра";
                op.Multiselect = true;
                if (op.ShowDialog() == DialogResult.OK)
                {
                    var files = op.FileNames;
                    var default_url = @"http://192.168.0.103/watch.html";
                    int i = movies.Count;
                    foreach (var f in files)
                    {
                        film_list.Add(Path.GetFileNameWithoutExtension(f));
                        movies.Add(new Movie(i, default_url, "", Path.GetFileNameWithoutExtension(f), f));
                        i++;
                    }
                    //list_films.DataSource = film_list;
                }
                foreach (var item in movies)
                {
                    list_films.Items.Add(item.Title);
                }
                list_films.Enabled = true;
                save_list.Enabled = true;
                SaveFilms();
            }
        }

        private void SaveFilms()
        {
            var p = content_path + @"/add.html";
            File.Delete(p);
            items.Clear();
            foreach (var item in movies)
            {
                items.Add(new Item(item.Url, item.Poster, item.Title, item.Path));
            }

            foreach (var item in items)
            {
                File.AppendAllLines(p, item.content);
            }

            list_films.Items.Clear();
            foreach (var item in movies)
            {
                list_films.Items.Add(item.Title);
            }
        }

        public string Serialize()
        {
            Directory.CreateDirectory(AppContext.BaseDirectory + @"/list/");
            var playlist = AppContext.BaseDirectory + @"/list/default.json";
            var file = JsonConvert.SerializeObject(movies, Formatting.Indented);
            File.WriteAllText(playlist, file);

            return file.ToString();
        }

        public void Deserialize()
        {
            var file = File.ReadAllText(AppContext.BaseDirectory + @"/list/default.json");
            movies = JsonConvert.DeserializeObject<List<Movie>>(file);
        }

        private void save_list_Click(object sender, EventArgs e)
        {
            //тут будет сериализация списка фильмов
            Serialize();
        }

        private void list_films_DoubleClick(object sender, EventArgs e)
        {
            if (list_films.SelectedItems.Count >= 0)
            {
                var index = list_films.Items.IndexOf(list_films.SelectedItems[0]);
                film_index_selected = index;
                var film = items[index].path;
                film_caption.Text = items[index].title;
                get_film_caption.Text = items[index].title;
                get_film_poster_url.Text = items[index].img_url;
                poster_img.ImageLocation = items[index].img_url;
                get_film_caption.Visible = true;
                get_film_poster_url.Visible = true;
                path_to_poster.Visible = true;
                get_poster_btn.Visible = true;
                apply_new_title.Visible = true;
                global_apply.Visible = true;
            }
        }

        private void list_films_Click(object sender, EventArgs e)
        {
            if (list_films.SelectedIndices.Count >= 0)
            {
                var index = list_films.Items.IndexOf(list_films.SelectedItems[0]);
                film_index_selected = index;
                var film = items[index].path;
                film_caption.Text = items[index].title;
                get_film_caption.Text = items[index].title;
                get_film_poster_url.Text = items[index].img_url;
                poster_img.ImageLocation = items[index].img_url;
                film_path.Text = items[index].path;
                goto_stream.Enabled = true;
            }
        }

        private void apply_new_title_Click(object sender, EventArgs e)
        {
            var new_title = get_film_caption.Text;
            movies[film_index_selected].Title = new_title;
            items[film_index_selected].title = new_title;

            var p = content_path + @"/add.html";
            File.Delete(p);
            items.Clear();
            foreach (var item in movies)
            {
                items.Add(new Item(item.Url, item.Poster, item.Title, item.Path));
            }
            foreach (var item in items)
            {
                File.AppendAllLines(p, item.content);
            }
            list_films.Items.Clear();
            foreach (var item in movies)
            {
                list_films.Items.Add(item.Title);
            }
        }

        private void get_poster_btn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog open_dlg = new OpenFileDialog())
            {
                open_dlg.Filter = "JPEG file *.jpg|*.jpg|PNG file *.png|*.png";
                open_dlg.Title = "Выбор нового постера для фильма";
                if (open_dlg.ShowDialog() == DialogResult.OK)
                {
                    var pic = open_dlg.FileName;
                    var path_on_server = $"http://192.168.0.103/poster/{movies[film_index_selected].Id}_poster.jpg";
                    File.Copy(pic, content_path + $@"/poster/{movies[film_index_selected].Id}_poster.jpg", true);
                    movies[film_index_selected].Poster = path_on_server;
                    items[film_index_selected].img_url = path_on_server;
                    get_film_poster_url.Text = items[film_index_selected].img_url;
                    poster_img.ImageLocation = items[film_index_selected].img_url;
                }
            }
            var p = content_path + @"/add.html";
            File.Delete(p);
            items.Clear();
            foreach (var item in movies)
            {
                items.Add(new Item(item.Url, item.Poster, item.Title, item.Path));
            }
            foreach (var item in items)
            {
                File.AppendAllLines(p, item.content);
            }
            list_films.Items.Clear();
            foreach (var item in movies)
            {
                list_films.Items.Add(item.Title);
            }
        }

        private async void find_Click(object sender, EventArgs e)
        {
            var film_name = movies[film_index_selected].Title;
            await GetPic(film_name);
            //MessageBox.Show(poster_url);
            if (poster_url != null)
            {
                WebClient client = new WebClient();
                client.DownloadFile(poster_url, content_path + $@"/poster/{movies[film_index_selected].Id}_poster.jpg");

                var path_on_server = $"http://192.168.0.103/poster/{movies[film_index_selected].Id}_poster.jpg";
                get_film_poster_url.Text = items[film_index_selected].img_url;
                poster_img.ImageLocation = items[film_index_selected].img_url;
                movies[film_index_selected].Poster = path_on_server;
                items[film_index_selected].img_url = path_on_server;

                var p = content_path + @"/add.html";
                File.Delete(p);
                items.Clear();
                foreach (var item in movies)
                {
                    items.Add(new Item(item.Url, item.Poster, item.Title, item.Path));
                }
                foreach (var item in items)
                {
                    File.AppendAllLines(p, item.content);
                }
                list_films.Items.Clear();
                foreach (var item in movies)
                {
                    list_films.Items.Add(item.Title);
                }
            }
        }

        private void global_apply_Click(object sender, EventArgs e)
        {
            get_film_caption.Visible = false;
            get_film_poster_url.Visible = false;
            get_poster_btn.Visible = false;
            apply_new_title.Visible = false;
            path_to_poster.Visible = false;
            global_apply.Visible = false;
        }

        private void load_list_Click(object sender, EventArgs e)
        {
            Deserialize();
            list_films.Enabled = true;
            SaveFilms();
            save_list.Enabled = true;
        }

        private void clear_all_Click(object sender, EventArgs e)
        {
            list_films.Items.Clear();
            film_list.Clear();
            items.Clear();
            movies.Clear();
            list_films.Enabled=false;
            film_caption.Text = "...";
            film_path.Text = "...";
            poster_img.Image = null;
            goto_stream.Enabled = false;
            save_list.Enabled=false;
        }

        private void goto_stream_Click(object sender, EventArgs e)
        {
            var film_p = items[film_index_selected].path;
            file = film_p;
            table.SelectedTab = table.TabPages[0];
            status = Status.Ready;
            file_cap.Text = $"Filename: {Path.GetFileName(file)}";
            VideoSize(file);
            GetQuality(file);            
            quality.Enabled = true;
            start_mc.Enabled = true;
            reset.Enabled = true;
        }

        #endregion
    }
}
