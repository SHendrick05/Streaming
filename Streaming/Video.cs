using Microsoft.WindowsAPICodePack.Shell;
using System.Drawing;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Streaming
{
    public static class VideoLoad
    {
        public static List<Video> videoList = new List<Video>();
        public static void Init()
        {
            string[] vids = File.ReadAllLines(@"videos\list.txt");
            int vidsC = (int)System.Math.Floor(vids.Length / 4.0);
            for(int i = 0; i < vidsC*4; i += 4)
            {
                videoList.Add(new Video(vids[i], vids[i + 1], uint.Parse(vids[i + 2]), vids[i + 3]));
            }

            List<string> paths = videoList.ConvertAll(x => x.path);

            foreach(string file in Directory.EnumerateFiles("videos", "*.mp4"))
            {
                System.Console.WriteLine(file);
                if (!paths.Contains(file))
                {
                    string title1 = file.Substring(0, file.Length - 4);
                    string title = title1.Substring(7);
                    videoList.Add(new Video(file, title, 0, "Video"));
                    File.AppendAllLines(@"videos\list.txt", new string[] {file, title, "0", "Video" });
                }
            }
        }
    }
        
    public class Video
    {
        public Video(string pth, string Title, uint Views, string dsc)
        {

            views = Views;
            title = Title;
            desc = dsc;
            path = pth;

            ShellFile shellFile = ShellFile.FromFilePath(pth);
            thumbnail = shellFile.Thumbnail.Bitmap;
        }

        public uint views { get; set; }
        internal Bitmap thumbnail { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        internal string path { get; set; }

        internal Panel pnl { get; set; }
    }
}
