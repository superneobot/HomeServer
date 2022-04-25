using System;

namespace HomeServer
{
    [Serializable]
    public class Item
    {
        public int Id { get; set; }
        public string[] content { get; set; }
        public string http_url { get; set; }
        public string img_url { get; set; }
        public string title { get; set; }
        public string path { get; set; }

        public Item(int _id, string _url, string _img, string _title, string _path)
        {
            http_url = _url;
            img_url = _img;
            title = _title;
            path = _path;
            string[] code =
            {
               $"<div class=\"item\" id=\"div{_id}\">",
               $"<a id=\"id{_id}\" href=\"{_url}\" title=\"{_title}\" style=\"box-shadow:0 0; \">",
               $"<img id=\"pic{_id}\" src=\"{_img}\" alt=\"{_title}\">",
               $"<a id = \"name{_id}\" href=\"{_url}\" title=\"{_title}\" class=\"item-name\">{_title}</a>",
               $"</a>",
               $"</div>"
            };

            content = code;
        }
    }
}
