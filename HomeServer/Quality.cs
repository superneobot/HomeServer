using NReco.VideoInfo;
using System.Collections.Generic;
public enum QList
{
    FHD = 0,
    QHD = 1,
    UHD = 2,
    HHD = 3
}
namespace StreamServer
{
    public class Quality
    {
        public string Name { get; set; }
        public string File { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public string[] param { get; set; }
        public int Bitrate { get; set; }

        public string Url { get; set; }

        QList quality_list { get; set; }

        public Quality(QList qList, string _name, string _file)
        {
            quality_list = qList;
            Name = _name;
            File = _file;
            List<int> data = new List<int>();
            data = GetVideoInfo(_file);
            if (quality_list == QList.HHD)
            {
                if (data[0] > 3000)
                {
                    Width = data[0] / 4;
                    Height = data[1] / 4;
                }
                else
                {
                    Width = data[0] / 2;
                    Height = data[1] / 2;
                }
                param = new string[]
                {
                    ":sout=#transcode{vcodec=h264,vb="+Bitrate+",venc=x264{profile=baseline},width="+Width+",height="+Height+",acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":http{mux=ts, sdp="+Url+"}",
                        ":sout-keep",
                        ":no-sout-all"
                };
            }
            if (quality_list == QList.FHD)
            {
                if (data[0] > 3000)
                {
                    Width = data[0] / 2;
                    Height = data[1] / 2;
                }
                else
                {
                    Width = data[0];
                    Height = data[1];
                }
                param = new string[]
                {
                    ":sout=#transcode{vcodec=h264,vb="+Bitrate+",venc=x264{profile=baseline},width="+Width+",height="+Height+",acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":http{mux=ts, sdp="+Url+"}",
                        ":sout-keep",
                        ":no-sout-all"
                };
            }
            if (quality_list == QList.QHD)
            {
                if (data[0] > 3000)
                {
                    Width = (int)(data[0] / 1.5);
                    Height = (int)(data[1] / 1.5);
                }
                else
                {
                    Width = (int)(data[0] * 1.5);
                    Height = (int)(data[1] * 1.5);
                }
                param = new string[]
                {
                    ":sout=#transcode{vcodec=h264,vb="+Bitrate+",venc=x264{profile=baseline},width="+Width+",height="+Height+",acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":http{mux=ts, sdp="+Url+"}",
                        ":sout-keep",
                        ":no-sout-all"
                };
            }
            if (quality_list == QList.UHD)
            {
                if (data[0] > 3000)
                {
                    Width = (int)(data[0]);
                    Height = (int)(data[1]);
                }
                else
                {
                    Width = (int)(data[0] * 2);
                    Height = (int)(data[1] * 2);
                }
                param = new string[]
                {
                    ":sout=#transcode{vcodec=h264,vb="+Bitrate+",venc=x264{profile=baseline},width="+Width+",height="+Height+",acodec=mpga,ab=192,channels=2,samplerate=44100,scodec=none}"+
                        ":http{mux=ts, sdp="+Url+"}",
                        ":sout-keep",
                        ":no-sout-all"
                };
            }
        }

        public List<int> GetVideoInfo(string filename)
        {
            var VideoData = new List<int>();

            var file = new FFProbe();
            var a = file.GetMediaInfo(filename);
            var width = a.Streams[0].Width;
            var height = a.Streams[0].Height;

            VideoData.Add(width);
            VideoData.Add(height);

            return VideoData;
        }
    }
}
