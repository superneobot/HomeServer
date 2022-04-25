namespace HomeServer
{
    partial class mainform
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainform));
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.web_server_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.mc_status = new System.Windows.Forms.ToolStripStatusLabel();
            this.req_state = new System.Windows.Forms.ToolStripStatusLabel();
            this.table = new System.Windows.Forms.TabControl();
            this.stream_page = new System.Windows.Forms.TabPage();
            this.progress = new MyProgressBar.MyProgressBar();
            this.marq = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reset = new System.Windows.Forms.Button();
            this.elapsed = new System.Windows.Forms.Label();
            this.brate = new System.Windows.Forms.ComboBox();
            this.start_mc = new System.Windows.Forms.Button();
            this.quality = new System.Windows.Forms.ComboBox();
            this.time = new System.Windows.Forms.Label();
            this.init_height = new System.Windows.Forms.Label();
            this.init_width = new System.Windows.Forms.Label();
            this.acodec_cap = new System.Windows.Forms.Label();
            this.vcodec_cap = new System.Windows.Forms.Label();
            this.height_cap = new System.Windows.Forms.Label();
            this.width_cap = new System.Windows.Forms.Label();
            this.stop_mc = new System.Windows.Forms.Button();
            this.file_cap = new System.Windows.Forms.Label();
            this.open_file = new System.Windows.Forms.Button();
            this.address_mediacenter = new System.Windows.Forms.TextBox();
            this.webserver_page = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.autostart_server = new System.Windows.Forms.CheckBox();
            this.open_local_path = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb1 = new System.Windows.Forms.Label();
            this.server_path = new System.Windows.Forms.TextBox();
            this.select = new System.Windows.Forms.Button();
            this.server_port = new System.Windows.Forms.NumericUpDown();
            this.ip4 = new System.Windows.Forms.NumericUpDown();
            this.ip3 = new System.Windows.Forms.NumericUpDown();
            this.ip2 = new System.Windows.Forms.NumericUpDown();
            this.ip1 = new System.Windows.Forms.NumericUpDown();
            this.start = new System.Windows.Forms.Button();
            this.mc_page = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.delete_selected = new System.Windows.Forms.Button();
            this.status_changes = new System.Windows.Forms.Label();
            this.current_url = new System.Windows.Forms.Label();
            this.replace_to_server_btn = new System.Windows.Forms.Button();
            this.get_film_url = new System.Windows.Forms.TextBox();
            this.goto_stream = new System.Windows.Forms.Button();
            this.clear_all = new System.Windows.Forms.Button();
            this.load_list = new System.Windows.Forms.Button();
            this.global_apply = new System.Windows.Forms.Button();
            this.apply_new_title = new System.Windows.Forms.Button();
            this.get_poster_btn = new System.Windows.Forms.Button();
            this.path_to_poster = new System.Windows.Forms.TextBox();
            this.get_film_poster_url = new System.Windows.Forms.TextBox();
            this.get_film_caption = new System.Windows.Forms.TextBox();
            this.save_list = new System.Windows.Forms.Button();
            this.film_path = new System.Windows.Forms.Label();
            this.film_caption = new System.Windows.Forms.Label();
            this.poster_img = new System.Windows.Forms.PictureBox();
            this.poster_img_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.find = new System.Windows.Forms.ToolStripMenuItem();
            this.find_hd_poster = new System.Windows.Forms.ToolStripMenuItem();
            this.list_films = new System.Windows.Forms.ListBox();
            this.add_files = new System.Windows.Forms.Button();
            this.pl_timer = new System.Windows.Forms.Timer(this.components);
            this.changes_timer = new System.Windows.Forms.Timer(this.components);
            this.requester = new System.Windows.Forms.Timer(this.components);
            this.perm_exit = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.table.SuspendLayout();
            this.stream_page.SuspendLayout();
            this.webserver_page.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_port)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).BeginInit();
            this.mc_page.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_img)).BeginInit();
            this.poster_img_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.web_server_status,
            this.mc_status,
            this.req_state});
            this.statusStrip1.Location = new System.Drawing.Point(5, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(524, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // web_server_status
            // 
            this.web_server_status.Name = "web_server_status";
            this.web_server_status.Size = new System.Drawing.Size(137, 17);
            this.web_server_status.Text = "Веб-сервер остановлен";
            // 
            // mc_status
            // 
            this.mc_status.Name = "mc_status";
            this.mc_status.Size = new System.Drawing.Size(93, 17);
            this.mc_status.Text = "MC остановлен";
            // 
            // req_state
            // 
            this.req_state.Name = "req_state";
            this.req_state.Size = new System.Drawing.Size(13, 17);
            this.req_state.Text = "1";
            // 
            // table
            // 
            this.table.Controls.Add(this.stream_page);
            this.table.Controls.Add(this.webserver_page);
            this.table.Controls.Add(this.mc_page);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(5, 5);
            this.table.Name = "table";
            this.table.SelectedIndex = 0;
            this.table.Size = new System.Drawing.Size(524, 479);
            this.table.TabIndex = 10;
            this.table.SelectedIndexChanged += new System.EventHandler(this.table_SelectedIndexChanged);
            // 
            // stream_page
            // 
            this.stream_page.Controls.Add(this.perm_exit);
            this.stream_page.Controls.Add(this.progress);
            this.stream_page.Controls.Add(this.marq);
            this.stream_page.Controls.Add(this.label4);
            this.stream_page.Controls.Add(this.label5);
            this.stream_page.Controls.Add(this.label6);
            this.stream_page.Controls.Add(this.reset);
            this.stream_page.Controls.Add(this.elapsed);
            this.stream_page.Controls.Add(this.brate);
            this.stream_page.Controls.Add(this.start_mc);
            this.stream_page.Controls.Add(this.quality);
            this.stream_page.Controls.Add(this.time);
            this.stream_page.Controls.Add(this.init_height);
            this.stream_page.Controls.Add(this.init_width);
            this.stream_page.Controls.Add(this.acodec_cap);
            this.stream_page.Controls.Add(this.vcodec_cap);
            this.stream_page.Controls.Add(this.height_cap);
            this.stream_page.Controls.Add(this.width_cap);
            this.stream_page.Controls.Add(this.stop_mc);
            this.stream_page.Controls.Add(this.file_cap);
            this.stream_page.Controls.Add(this.open_file);
            this.stream_page.Controls.Add(this.address_mediacenter);
            this.stream_page.Location = new System.Drawing.Point(4, 22);
            this.stream_page.Name = "stream_page";
            this.stream_page.Padding = new System.Windows.Forms.Padding(3);
            this.stream_page.Size = new System.Drawing.Size(516, 453);
            this.stream_page.TabIndex = 0;
            this.stream_page.Text = "Стрим";
            this.stream_page.UseVisualStyleBackColor = true;
            // 
            // progress
            // 
            this.progress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(74)))));
            this.progress.BarColor = System.Drawing.Color.DarkSlateBlue;
            this.progress.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.progress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.progress.Location = new System.Drawing.Point(9, 186);
            this.progress.Maximum = 100;
            this.progress.Minimum = 0;
            this.progress.Name = "progress";
            this.progress.Progress = null;
            this.progress.ProgressPenColor = System.Drawing.Color.Black;
            this.progress.Size = new System.Drawing.Size(335, 20);
            this.progress.Step = 1;
            this.progress.TabIndex = 43;
            this.progress.Value = 0;
            // 
            // marq
            // 
            this.marq.AutoSize = true;
            this.marq.Location = new System.Drawing.Point(313, 26);
            this.marq.Name = "marq";
            this.marq.Size = new System.Drawing.Size(31, 13);
            this.marq.TabIndex = 42;
            this.marq.Text = "[ | | | ]";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 41;
            this.label4.Text = "Битрейт видео";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Качество";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "Адрес трансляции";
            // 
            // reset
            // 
            this.reset.Enabled = false;
            this.reset.Location = new System.Drawing.Point(6, 120);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 38;
            this.reset.Text = "reset";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // elapsed
            // 
            this.elapsed.AutoSize = true;
            this.elapsed.Location = new System.Drawing.Point(17, 158);
            this.elapsed.Name = "elapsed";
            this.elapsed.Size = new System.Drawing.Size(49, 13);
            this.elapsed.TabIndex = 37;
            this.elapsed.Text = "00:00:00";
            // 
            // brate
            // 
            this.brate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.brate.Enabled = false;
            this.brate.FormattingEnabled = true;
            this.brate.Location = new System.Drawing.Point(232, 22);
            this.brate.Name = "brate";
            this.brate.Size = new System.Drawing.Size(75, 21);
            this.brate.TabIndex = 36;
            this.brate.SelectedIndexChanged += new System.EventHandler(this.brate_SelectedIndexChanged);
            // 
            // start_mc
            // 
            this.start_mc.Enabled = false;
            this.start_mc.Location = new System.Drawing.Point(6, 73);
            this.start_mc.Name = "start_mc";
            this.start_mc.Size = new System.Drawing.Size(75, 23);
            this.start_mc.TabIndex = 35;
            this.start_mc.Text = "start";
            this.start_mc.UseVisualStyleBackColor = true;
            this.start_mc.Click += new System.EventHandler(this.start_mc_Click);
            // 
            // quality
            // 
            this.quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quality.Enabled = false;
            this.quality.FormattingEnabled = true;
            this.quality.Location = new System.Drawing.Point(155, 22);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(71, 21);
            this.quality.TabIndex = 34;
            this.quality.SelectedIndexChanged += new System.EventHandler(this.quality_SelectedIndexChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(17, 145);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(49, 13);
            this.time.TabIndex = 33;
            this.time.Text = "00:00:00";
            // 
            // init_height
            // 
            this.init_height.AutoSize = true;
            this.init_height.Location = new System.Drawing.Point(87, 157);
            this.init_height.Name = "init_height";
            this.init_height.Size = new System.Drawing.Size(75, 13);
            this.init_height.TabIndex = 32;
            this.init_height.Text = "Stream height:";
            // 
            // init_width
            // 
            this.init_width.AutoSize = true;
            this.init_width.Location = new System.Drawing.Point(87, 144);
            this.init_width.Name = "init_width";
            this.init_width.Size = new System.Drawing.Size(71, 13);
            this.init_width.TabIndex = 31;
            this.init_width.Text = "Stream width:";
            // 
            // acodec_cap
            // 
            this.acodec_cap.AutoSize = true;
            this.acodec_cap.Location = new System.Drawing.Point(87, 120);
            this.acodec_cap.Name = "acodec_cap";
            this.acodec_cap.Size = new System.Drawing.Size(71, 13);
            this.acodec_cap.TabIndex = 30;
            this.acodec_cap.Text = "Audio Codec:";
            // 
            // vcodec_cap
            // 
            this.vcodec_cap.AutoSize = true;
            this.vcodec_cap.Location = new System.Drawing.Point(87, 107);
            this.vcodec_cap.Name = "vcodec_cap";
            this.vcodec_cap.Size = new System.Drawing.Size(71, 13);
            this.vcodec_cap.TabIndex = 29;
            this.vcodec_cap.Text = "Video Codec:";
            // 
            // height_cap
            // 
            this.height_cap.AutoSize = true;
            this.height_cap.Location = new System.Drawing.Point(87, 91);
            this.height_cap.Name = "height_cap";
            this.height_cap.Size = new System.Drawing.Size(77, 13);
            this.height_cap.TabIndex = 28;
            this.height_cap.Text = "Original height:";
            // 
            // width_cap
            // 
            this.width_cap.AutoSize = true;
            this.width_cap.Location = new System.Drawing.Point(87, 78);
            this.width_cap.Name = "width_cap";
            this.width_cap.Size = new System.Drawing.Size(73, 13);
            this.width_cap.TabIndex = 27;
            this.width_cap.Text = "Orignial width:";
            // 
            // stop_mc
            // 
            this.stop_mc.Enabled = false;
            this.stop_mc.Location = new System.Drawing.Point(6, 97);
            this.stop_mc.Name = "stop_mc";
            this.stop_mc.Size = new System.Drawing.Size(75, 23);
            this.stop_mc.TabIndex = 26;
            this.stop_mc.Text = "stop";
            this.stop_mc.UseVisualStyleBackColor = true;
            this.stop_mc.Click += new System.EventHandler(this.stop_mc_Click);
            // 
            // file_cap
            // 
            this.file_cap.Location = new System.Drawing.Point(87, 49);
            this.file_cap.Name = "file_cap";
            this.file_cap.Size = new System.Drawing.Size(265, 29);
            this.file_cap.TabIndex = 25;
            this.file_cap.Text = "Filename: ";
            // 
            // open_file
            // 
            this.open_file.Location = new System.Drawing.Point(6, 49);
            this.open_file.Name = "open_file";
            this.open_file.Size = new System.Drawing.Size(75, 23);
            this.open_file.TabIndex = 24;
            this.open_file.Text = "open";
            this.open_file.UseVisualStyleBackColor = true;
            this.open_file.Click += new System.EventHandler(this.open_file_Click);
            // 
            // address_mediacenter
            // 
            this.address_mediacenter.CausesValidation = false;
            this.address_mediacenter.Location = new System.Drawing.Point(6, 23);
            this.address_mediacenter.Name = "address_mediacenter";
            this.address_mediacenter.ReadOnly = true;
            this.address_mediacenter.Size = new System.Drawing.Size(143, 20);
            this.address_mediacenter.TabIndex = 23;
            this.address_mediacenter.TabStop = false;
            this.address_mediacenter.Text = "http://192.168.0.103:8080/";
            this.address_mediacenter.DoubleClick += new System.EventHandler(this.address_mediacenter_DoubleClick);
            this.address_mediacenter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.address_mediacenter_KeyDown);
            // 
            // webserver_page
            // 
            this.webserver_page.Controls.Add(this.groupBox1);
            this.webserver_page.Location = new System.Drawing.Point(4, 22);
            this.webserver_page.Name = "webserver_page";
            this.webserver_page.Padding = new System.Windows.Forms.Padding(3);
            this.webserver_page.Size = new System.Drawing.Size(516, 453);
            this.webserver_page.TabIndex = 1;
            this.webserver_page.Text = "Настройки веб-сервера";
            this.webserver_page.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.autostart_server);
            this.groupBox1.Controls.Add(this.open_local_path);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lb1);
            this.groupBox1.Controls.Add(this.server_path);
            this.groupBox1.Controls.Add(this.select);
            this.groupBox1.Controls.Add(this.server_port);
            this.groupBox1.Controls.Add(this.ip4);
            this.groupBox1.Controls.Add(this.ip3);
            this.groupBox1.Controls.Add(this.ip2);
            this.groupBox1.Controls.Add(this.ip1);
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(510, 224);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Локальный веб-сервер";
            // 
            // autostart_server
            // 
            this.autostart_server.AutoSize = true;
            this.autostart_server.Location = new System.Drawing.Point(10, 189);
            this.autostart_server.Name = "autostart_server";
            this.autostart_server.Size = new System.Drawing.Size(230, 17);
            this.autostart_server.TabIndex = 21;
            this.autostart_server.Text = "Старт сервера при запуске приложения";
            this.autostart_server.UseVisualStyleBackColor = true;
            this.autostart_server.Click += new System.EventHandler(this.autostart_server_Click);
            // 
            // open_local_path
            // 
            this.open_local_path.Location = new System.Drawing.Point(264, 67);
            this.open_local_path.Name = "open_local_path";
            this.open_local_path.Size = new System.Drawing.Size(75, 23);
            this.open_local_path.TabIndex = 20;
            this.open_local_path.Text = "Открыть";
            this.open_local_path.UseVisualStyleBackColor = true;
            this.open_local_path.Click += new System.EventHandler(this.open_local_path_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(8, 170);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(82, 13);
            this.linkLabel1.TabIndex = 19;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "remote_address";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Адрес веб-сервера: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Внешний IP адрес: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Локальный IP адрес: ";
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(8, 51);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(128, 13);
            this.lb1.TabIndex = 15;
            this.lb1.Text = "Выбрать папку сервера";
            // 
            // server_path
            // 
            this.server_path.Location = new System.Drawing.Point(87, 69);
            this.server_path.Name = "server_path";
            this.server_path.ReadOnly = true;
            this.server_path.Size = new System.Drawing.Size(173, 20);
            this.server_path.TabIndex = 14;
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(6, 67);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(75, 23);
            this.select.TabIndex = 13;
            this.select.Text = "Выбрать";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // server_port
            // 
            this.server_port.Location = new System.Drawing.Point(295, 20);
            this.server_port.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.server_port.Name = "server_port";
            this.server_port.Size = new System.Drawing.Size(46, 20);
            this.server_port.TabIndex = 8;
            this.server_port.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.server_port.Click += new System.EventHandler(this.server_port_ValueChanged);
            // 
            // ip4
            // 
            this.ip4.Location = new System.Drawing.Point(243, 20);
            this.ip4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip4.Name = "ip4";
            this.ip4.Size = new System.Drawing.Size(46, 20);
            this.ip4.TabIndex = 9;
            this.ip4.Value = new decimal(new int[] {
            103,
            0,
            0,
            0});
            this.ip4.Click += new System.EventHandler(this.ip4_ValueChanged);
            // 
            // ip3
            // 
            this.ip3.Location = new System.Drawing.Point(191, 20);
            this.ip3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip3.Name = "ip3";
            this.ip3.Size = new System.Drawing.Size(46, 20);
            this.ip3.TabIndex = 10;
            this.ip3.Click += new System.EventHandler(this.ip3_ValueChanged);
            // 
            // ip2
            // 
            this.ip2.Location = new System.Drawing.Point(139, 20);
            this.ip2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip2.Name = "ip2";
            this.ip2.Size = new System.Drawing.Size(46, 20);
            this.ip2.TabIndex = 11;
            this.ip2.Value = new decimal(new int[] {
            168,
            0,
            0,
            0});
            this.ip2.Click += new System.EventHandler(this.ip2_ValueChanged);
            // 
            // ip1
            // 
            this.ip1.Location = new System.Drawing.Point(87, 20);
            this.ip1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.ip1.Name = "ip1";
            this.ip1.Size = new System.Drawing.Size(46, 20);
            this.ip1.TabIndex = 12;
            this.ip1.Value = new decimal(new int[] {
            192,
            0,
            0,
            0});
            this.ip1.Click += new System.EventHandler(this.ip1_ValueChanged);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(6, 19);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 23);
            this.start.TabIndex = 7;
            this.start.Text = "Старт";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // mc_page
            // 
            this.mc_page.Controls.Add(this.button1);
            this.mc_page.Controls.Add(this.delete_selected);
            this.mc_page.Controls.Add(this.status_changes);
            this.mc_page.Controls.Add(this.current_url);
            this.mc_page.Controls.Add(this.replace_to_server_btn);
            this.mc_page.Controls.Add(this.get_film_url);
            this.mc_page.Controls.Add(this.goto_stream);
            this.mc_page.Controls.Add(this.clear_all);
            this.mc_page.Controls.Add(this.load_list);
            this.mc_page.Controls.Add(this.global_apply);
            this.mc_page.Controls.Add(this.apply_new_title);
            this.mc_page.Controls.Add(this.get_poster_btn);
            this.mc_page.Controls.Add(this.path_to_poster);
            this.mc_page.Controls.Add(this.get_film_poster_url);
            this.mc_page.Controls.Add(this.get_film_caption);
            this.mc_page.Controls.Add(this.save_list);
            this.mc_page.Controls.Add(this.film_path);
            this.mc_page.Controls.Add(this.film_caption);
            this.mc_page.Controls.Add(this.poster_img);
            this.mc_page.Controls.Add(this.list_films);
            this.mc_page.Controls.Add(this.add_files);
            this.mc_page.Location = new System.Drawing.Point(4, 22);
            this.mc_page.Name = "mc_page";
            this.mc_page.Padding = new System.Windows.Forms.Padding(3);
            this.mc_page.Size = new System.Drawing.Size(516, 453);
            this.mc_page.TabIndex = 2;
            this.mc_page.Text = "Медиацентр";
            this.mc_page.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(413, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // delete_selected
            // 
            this.delete_selected.Enabled = false;
            this.delete_selected.Location = new System.Drawing.Point(87, 6);
            this.delete_selected.Name = "delete_selected";
            this.delete_selected.Size = new System.Drawing.Size(94, 23);
            this.delete_selected.TabIndex = 18;
            this.delete_selected.Text = "Удалить выбранный";
            this.delete_selected.UseVisualStyleBackColor = true;
            this.delete_selected.Click += new System.EventHandler(this.delete_selected_Click);
            // 
            // status_changes
            // 
            this.status_changes.AutoSize = true;
            this.status_changes.Location = new System.Drawing.Point(182, 421);
            this.status_changes.Name = "status_changes";
            this.status_changes.Size = new System.Drawing.Size(35, 13);
            this.status_changes.TabIndex = 17;
            this.status_changes.Text = "label7";
            // 
            // current_url
            // 
            this.current_url.Location = new System.Drawing.Point(182, 219);
            this.current_url.Name = "current_url";
            this.current_url.Size = new System.Drawing.Size(328, 41);
            this.current_url.TabIndex = 16;
            this.current_url.Text = "...";
            // 
            // replace_to_server_btn
            // 
            this.replace_to_server_btn.Location = new System.Drawing.Point(405, 341);
            this.replace_to_server_btn.Name = "replace_to_server_btn";
            this.replace_to_server_btn.Size = new System.Drawing.Size(75, 23);
            this.replace_to_server_btn.TabIndex = 15;
            this.replace_to_server_btn.Text = "replace";
            this.replace_to_server_btn.UseVisualStyleBackColor = true;
            this.replace_to_server_btn.Visible = false;
            this.replace_to_server_btn.Click += new System.EventHandler(this.replace_to_server_btn_Click);
            // 
            // get_film_url
            // 
            this.get_film_url.Location = new System.Drawing.Point(185, 342);
            this.get_film_url.Name = "get_film_url";
            this.get_film_url.ReadOnly = true;
            this.get_film_url.Size = new System.Drawing.Size(214, 20);
            this.get_film_url.TabIndex = 14;
            this.get_film_url.Visible = false;
            this.get_film_url.Click += new System.EventHandler(this.get_film_caption_Click);
            // 
            // goto_stream
            // 
            this.goto_stream.Enabled = false;
            this.goto_stream.Location = new System.Drawing.Point(185, 263);
            this.goto_stream.Name = "goto_stream";
            this.goto_stream.Size = new System.Drawing.Size(181, 23);
            this.goto_stream.TabIndex = 13;
            this.goto_stream.Text = "Отправить фильм на стрим";
            this.goto_stream.UseVisualStyleBackColor = true;
            this.goto_stream.Click += new System.EventHandler(this.goto_stream_Click);
            // 
            // clear_all
            // 
            this.clear_all.Location = new System.Drawing.Point(420, 6);
            this.clear_all.Name = "clear_all";
            this.clear_all.Size = new System.Drawing.Size(90, 23);
            this.clear_all.TabIndex = 12;
            this.clear_all.Text = "Очистить";
            this.clear_all.UseVisualStyleBackColor = true;
            this.clear_all.Click += new System.EventHandler(this.clear_all_Click);
            // 
            // load_list
            // 
            this.load_list.Location = new System.Drawing.Point(303, 6);
            this.load_list.Name = "load_list";
            this.load_list.Size = new System.Drawing.Size(110, 23);
            this.load_list.TabIndex = 11;
            this.load_list.Text = "Загрузить список";
            this.load_list.UseVisualStyleBackColor = true;
            this.load_list.Click += new System.EventHandler(this.load_list_Click);
            // 
            // global_apply
            // 
            this.global_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.global_apply.Location = new System.Drawing.Point(185, 397);
            this.global_apply.Name = "global_apply";
            this.global_apply.Size = new System.Drawing.Size(214, 21);
            this.global_apply.TabIndex = 10;
            this.global_apply.Text = "Принять изменения";
            this.global_apply.UseVisualStyleBackColor = true;
            this.global_apply.Visible = false;
            this.global_apply.Click += new System.EventHandler(this.global_apply_Click);
            // 
            // apply_new_title
            // 
            this.apply_new_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.apply_new_title.Location = new System.Drawing.Point(453, 292);
            this.apply_new_title.Name = "apply_new_title";
            this.apply_new_title.Size = new System.Drawing.Size(27, 21);
            this.apply_new_title.TabIndex = 10;
            this.apply_new_title.Text = "ok";
            this.apply_new_title.UseVisualStyleBackColor = true;
            this.apply_new_title.Visible = false;
            this.apply_new_title.Click += new System.EventHandler(this.apply_new_title_Click);
            // 
            // get_poster_btn
            // 
            this.get_poster_btn.Location = new System.Drawing.Point(405, 369);
            this.get_poster_btn.Name = "get_poster_btn";
            this.get_poster_btn.Size = new System.Drawing.Size(75, 23);
            this.get_poster_btn.TabIndex = 9;
            this.get_poster_btn.Text = "open";
            this.get_poster_btn.UseVisualStyleBackColor = true;
            this.get_poster_btn.Visible = false;
            this.get_poster_btn.Click += new System.EventHandler(this.get_poster_btn_Click);
            // 
            // path_to_poster
            // 
            this.path_to_poster.Location = new System.Drawing.Point(185, 371);
            this.path_to_poster.Name = "path_to_poster";
            this.path_to_poster.ReadOnly = true;
            this.path_to_poster.Size = new System.Drawing.Size(214, 20);
            this.path_to_poster.TabIndex = 8;
            this.path_to_poster.Visible = false;
            // 
            // get_film_poster_url
            // 
            this.get_film_poster_url.Location = new System.Drawing.Point(185, 318);
            this.get_film_poster_url.Name = "get_film_poster_url";
            this.get_film_poster_url.ReadOnly = true;
            this.get_film_poster_url.Size = new System.Drawing.Size(295, 20);
            this.get_film_poster_url.TabIndex = 7;
            this.get_film_poster_url.Visible = false;
            this.get_film_poster_url.Click += new System.EventHandler(this.get_film_caption_Click);
            // 
            // get_film_caption
            // 
            this.get_film_caption.Location = new System.Drawing.Point(185, 292);
            this.get_film_caption.Name = "get_film_caption";
            this.get_film_caption.Size = new System.Drawing.Size(262, 20);
            this.get_film_caption.TabIndex = 6;
            this.get_film_caption.Visible = false;
            this.get_film_caption.DoubleClick += new System.EventHandler(this.get_film_caption_Click);
            this.get_film_caption.KeyDown += new System.Windows.Forms.KeyEventHandler(this.get_film_caption_KeyDown);
            // 
            // save_list
            // 
            this.save_list.Enabled = false;
            this.save_list.Location = new System.Drawing.Point(187, 6);
            this.save_list.Name = "save_list";
            this.save_list.Size = new System.Drawing.Size(110, 23);
            this.save_list.TabIndex = 5;
            this.save_list.Text = "Сохранить список";
            this.save_list.UseVisualStyleBackColor = true;
            this.save_list.Click += new System.EventHandler(this.save_list_Click);
            // 
            // film_path
            // 
            this.film_path.AutoSize = true;
            this.film_path.Location = new System.Drawing.Point(182, 203);
            this.film_path.Name = "film_path";
            this.film_path.Size = new System.Drawing.Size(16, 13);
            this.film_path.TabIndex = 4;
            this.film_path.Text = "...";
            // 
            // film_caption
            // 
            this.film_caption.AutoSize = true;
            this.film_caption.Location = new System.Drawing.Point(182, 188);
            this.film_caption.Name = "film_caption";
            this.film_caption.Size = new System.Drawing.Size(16, 13);
            this.film_caption.TabIndex = 3;
            this.film_caption.Text = "...";
            // 
            // poster_img
            // 
            this.poster_img.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.poster_img.ContextMenuStrip = this.poster_img_menu;
            this.poster_img.Location = new System.Drawing.Point(6, 188);
            this.poster_img.Name = "poster_img";
            this.poster_img.Size = new System.Drawing.Size(170, 239);
            this.poster_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poster_img.TabIndex = 2;
            this.poster_img.TabStop = false;
            // 
            // poster_img_menu
            // 
            this.poster_img_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.find,
            this.find_hd_poster});
            this.poster_img_menu.Name = "poster_img_menu";
            this.poster_img_menu.Size = new System.Drawing.Size(283, 48);
            // 
            // find
            // 
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(282, 22);
            this.find.Text = "Найти случайный постер в интернете";
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // find_hd_poster
            // 
            this.find_hd_poster.Name = "find_hd_poster";
            this.find_hd_poster.Size = new System.Drawing.Size(282, 22);
            this.find_hd_poster.Text = "Поиск постера в ручную в интернете";
            this.find_hd_poster.Click += new System.EventHandler(this.find_hd_poster_Click);
            // 
            // list_films
            // 
            this.list_films.Enabled = false;
            this.list_films.FormattingEnabled = true;
            this.list_films.Location = new System.Drawing.Point(6, 35);
            this.list_films.Name = "list_films";
            this.list_films.Size = new System.Drawing.Size(504, 147);
            this.list_films.TabIndex = 1;
            this.list_films.Click += new System.EventHandler(this.list_films_Click);
            this.list_films.DoubleClick += new System.EventHandler(this.list_films_DoubleClick);
            // 
            // add_files
            // 
            this.add_files.Location = new System.Drawing.Point(6, 6);
            this.add_files.Name = "add_files";
            this.add_files.Size = new System.Drawing.Size(75, 23);
            this.add_files.TabIndex = 0;
            this.add_files.Text = "Добавить";
            this.add_files.UseVisualStyleBackColor = true;
            this.add_files.Click += new System.EventHandler(this.add_files_Click);
            // 
            // pl_timer
            // 
            this.pl_timer.Tick += new System.EventHandler(this.pl_timer_Tick);
            // 
            // changes_timer
            // 
            this.changes_timer.Enabled = true;
            this.changes_timer.Tick += new System.EventHandler(this.changes_timer_Tick);
            // 
            // requester
            // 
            this.requester.Enabled = true;
            this.requester.Interval = 3000;
            this.requester.Tick += new System.EventHandler(this.requester_Tick);
            // 
            // perm_exit
            // 
            this.perm_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.perm_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perm_exit.Location = new System.Drawing.Point(336, 2);
            this.perm_exit.Name = "perm_exit";
            this.perm_exit.Size = new System.Drawing.Size(18, 18);
            this.perm_exit.TabIndex = 44;
            this.perm_exit.Text = "x";
            this.perm_exit.UseVisualStyleBackColor = true;
            this.perm_exit.Click += new System.EventHandler(this.perm_exit_Click);
            // 
            // mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 511);
            this.Controls.Add(this.table);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainform";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainform_FormClosing);
            this.Load += new System.EventHandler(this.mainform_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.table.ResumeLayout(false);
            this.stream_page.ResumeLayout(false);
            this.stream_page.PerformLayout();
            this.webserver_page.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.server_port)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ip1)).EndInit();
            this.mc_page.ResumeLayout(false);
            this.mc_page.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.poster_img)).EndInit();
            this.poster_img_menu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl table;
        private System.Windows.Forms.TabPage stream_page;
        private System.Windows.Forms.TabPage webserver_page;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button open_local_path;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox server_path;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.NumericUpDown server_port;
        private System.Windows.Forms.NumericUpDown ip4;
        private System.Windows.Forms.NumericUpDown ip3;
        private System.Windows.Forms.NumericUpDown ip2;
        private System.Windows.Forms.NumericUpDown ip1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.CheckBox autostart_server;
        private System.Windows.Forms.ToolStripStatusLabel web_server_status;
        private System.Windows.Forms.Label marq;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button reset;
        private System.Windows.Forms.Label elapsed;
        private System.Windows.Forms.ComboBox brate;
        public System.Windows.Forms.Button start_mc;
        private System.Windows.Forms.ComboBox quality;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label init_height;
        private System.Windows.Forms.Label init_width;
        private System.Windows.Forms.Label acodec_cap;
        private System.Windows.Forms.Label vcodec_cap;
        private System.Windows.Forms.Label height_cap;
        private System.Windows.Forms.Label width_cap;
        private System.Windows.Forms.Button stop_mc;
        private System.Windows.Forms.Label file_cap;
        private System.Windows.Forms.Button open_file;
        private System.Windows.Forms.TextBox address_mediacenter;
        private MyProgressBar.MyProgressBar progress;
        private System.Windows.Forms.Timer pl_timer;
        private System.Windows.Forms.ToolStripStatusLabel mc_status;
        private System.Windows.Forms.TabPage mc_page;
        private System.Windows.Forms.Label film_path;
        private System.Windows.Forms.Label film_caption;
        private System.Windows.Forms.PictureBox poster_img;
        private System.Windows.Forms.ListBox list_films;
        private System.Windows.Forms.Button add_files;
        private System.Windows.Forms.Button save_list;
        private System.Windows.Forms.Button get_poster_btn;
        private System.Windows.Forms.TextBox path_to_poster;
        private System.Windows.Forms.TextBox get_film_poster_url;
        private System.Windows.Forms.TextBox get_film_caption;
        private System.Windows.Forms.Button global_apply;
        private System.Windows.Forms.Button apply_new_title;
        private System.Windows.Forms.ContextMenuStrip poster_img_menu;
        private System.Windows.Forms.ToolStripMenuItem find;
        private System.Windows.Forms.Button load_list;
        private System.Windows.Forms.Button clear_all;
        private System.Windows.Forms.Button goto_stream;
        private System.Windows.Forms.TextBox get_film_url;
        private System.Windows.Forms.Button replace_to_server_btn;
        private System.Windows.Forms.Label current_url;
        private System.Windows.Forms.Label status_changes;
        private System.Windows.Forms.Timer changes_timer;
        private System.Windows.Forms.Button delete_selected;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer requester;
        private System.Windows.Forms.ToolStripStatusLabel req_state;
        private System.Windows.Forms.ToolStripMenuItem find_hd_poster;
        private System.Windows.Forms.Button perm_exit;
    }
}

