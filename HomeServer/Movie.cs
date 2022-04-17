using System;

namespace HomeServer
{
    [Serializable]
    public class Movie
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Poster { get; set; }
        public string Title { get; set; }
        public string Path { get; set; }

        public Movie(int _id, string _url, string _poster, string _title, string _path)
        {
            Id = _id;
            Url = _url;
            Poster = _poster;
            Title = _title;
            Path = _path;
        }

    }
}
