using System;

namespace HomeServer
{
    [Serializable]
    public class Item
    {
        public string[] content { get; set; }
        public string http_url { get; set; }
        public string img_url { get; set; }
        public string title { get; set; }
        public string path { get; set; }

        public Item(string _url, string _img, string _title, string _path)
        {
            http_url = _url;
            img_url = _img;
            title = _title;
            path = _path;
            string[] code =
            {
                $"<div class=\"item\">",
                $"<a href=\"{_url}\" title=\"{_title}\" rel=\"nofollow\">",
                $"<img src=\"{_img}\" alt=\"{_title}\">",
                $"<a href=\"{_url}\" title=\"{_title}\" class=\"item-name\">{_title}</a>Кино",
                $"</a>",
                $"</div>"
            };

            content = code;
        }
    }
}
