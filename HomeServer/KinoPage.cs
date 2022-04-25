using AngleSharp.Dom;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace HomeServer
{
    public class KinoPage
    {
        public string Title { get; set; }
        public string Url { get; set; }
        public string[] Code { get; set; }
        public string Source { get; set; }
        public KinoPage(string _title, string _url, string _source)
        {
            Title = _title;
            Url = _url;
            Source = _source;
            //CreateKinoPage();
        }

        public void CreateKinoPage()
        {
            string[] code =
{
                $"<html lang=\"ru\">",
                $"<head>",
                $"<meta http-equiv=\"Content-Type\" content=\"text/html; charset = windows - 1251\">",
                $"<title>{Title}</title>",
                $"<link rel=\"stylesheet\" type=\"text/css\" href=\"css/style.css\" />",
               // $"<script type=\"text/javascript\" src=\"js/jquery-1.9.1.js\" /></script>",
               // $"<script type=\"text/javascript\" src=\"js/jquery.mobile-1.3.2.js\" /></script>",
                $"<script type=\"text/javascript\" src=\"js/keyTizen.js\" /></script>",
                $"<script type=\"text/javascript\" src=\"js/main.js\" /></script>",
                $"<script type=\"text/javascript\" src=\"js/TVOperation.js\" /></script>",
                $"<script>",
                $"var myVideo = document.getElementById(\"video\");",
                $"myVideo.load();",
                $"myVideo.play();",
                $"</script>",
                $"</head>",
                $"<body bgcolor=\"#000000\">",
                $"<video id=\"video\" class=\"player\" width=\"1910\" height=\"1070\" controls=\"controls\" preload=\"auto\" autoplay=\"autoplay\" poster=\"{Url}\">",
                $"<source src=\"http://192.168.0.103:8080/\" type=\"video/mp4\" />",
                $"<track srclang=\"ru\">",
                $"</video>",
                $"</body>",
                $"</html>"
            };

            Code = code;
        }
    }
}
