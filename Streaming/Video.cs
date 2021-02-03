using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Streaming
{
    public static class VideoLoad
    {
        public static Random rndID = new Random();
        public static List<Video> videoList = new List<Video>();
        public static void Init()
        {
            Directory.CreateDirectory(@"videos");
            if (!File.Exists(@"videos\list.txt")) _ = File.Create(@"videos\list.txt");
            string[] vids = File.ReadAllLines(@"videos\list.txt");
            int vidsC = (int)System.Math.Floor(vids.Length / 4.0);
            for (int i = 0; i < vidsC * 4; i += 4)
            {
                videoList.Add(new Video(vids[i], vids[i + 1], uint.Parse(vids[i + 2]), vids[i + 3]));
            }

            List<string> paths = videoList.ConvertAll(x => x.Path);

            foreach (string file in Directory.EnumerateFiles("videos"))
            {
                if (!".mp4.avi.mov.webm.flv.wmv.mpeg4".Contains(Path.GetExtension(file))) continue;
                System.Console.WriteLine(file);
                if (!paths.Contains(file))
                {
                    string title1 = file.Substring(0, file.Length - 4);
                    string title = title1.Substring(7);
                    videoList.Add(new Video(file, title, 0, "Video"));
                    File.AppendAllLines(@"videos\list.txt", new string[] { file, title, "0", "Video" });
                }
            }
        }

        public static void Save()
        {
            List<string> lines = new List<string>();
            foreach (Video vid in videoList)
            {
                lines.Add(vid.Path);
                lines.Add(vid.Title);
                lines.Add(vid.Views.ToString());
                string DescToAdd = vid.Desc.Replace('\n'.ToString(), @"\n");
                lines.Add(DescToAdd);
            }
            File.WriteAllLines(@"videos\list.txt", lines);
        }
    }

    public class Video
    {
        public Video(string pth, string Title, uint Views, string dsc)
        {

            this.Views = Views;
            this.Title = Title;
            Desc = dsc;
            Path = pth;

            ShellFile shellFile = ShellFile.FromFilePath(pth);
            Thumbnail = shellFile.Thumbnail.Bitmap;
        }

        public uint Views { get; set; }
        internal Bitmap Thumbnail { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; }
        internal string Path { get; set; }
        internal int SScore { get; set; }
        internal Panel Pnl { get; set; }
    }
}
