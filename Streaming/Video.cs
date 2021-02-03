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
        public static void Init() // Get the videos from list.txt
        {
            Directory.CreateDirectory(@"videos");
            if (!File.Exists(@"videos\list.txt")) _ = File.Create(@"videos\list.txt"); // Create the lists.txt if not exist
            string[] vids = File.ReadAllLines(@"videos\list.txt");
            int vidsC = (int)System.Math.Floor(vids.Length / 4.0);
            for (int i = 0; i < vidsC * 4; i += 4)
            {
                videoList.Add(new Video(vids[i], vids[i + 1], uint.Parse(vids[i + 2]), vids[i + 3])); // Add videos from lists.txt
            }

            List<string> paths = videoList.ConvertAll(x => x.Path); // Get paths from the list

            foreach (string file in Directory.EnumerateFiles("videos")) // Add videos from the videos folder
            {
                if (!".mp4.avi.mov.webm.flv.wmv.mpeg4".Contains(Path.GetExtension(file))) continue;
                System.Console.WriteLine(file);
                if (!paths.Contains(file))
                {
                    string title1 = file.Substring(0, file.Length - 4);
                    string title = title1.Substring(7);
                    videoList.Add(new Video(file, title, 0, "Video"));
                    File.AppendAllLines(@"videos\list.txt", new string[] { file, title, "0", "Video" }); // Add to lists.txt
                }
            }
        }

        public static void Save() // Save the videos into list.txt
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

    public class Video // Video class to use
    {
        public Video(string pth, string Title, uint Views, string dsc) // Constructor
        {

            this.Views = Views;
            this.Title = Title;
            Desc = dsc;
            Path = pth;

            ShellFile shellFile = ShellFile.FromFilePath(pth); // Generate thumbnail 
            Thumbnail = shellFile.Thumbnail.Bitmap; 
        }

        public uint Views { get; set; }
        internal Bitmap Thumbnail { get; set; }
        public string Title { get; set; }
        public string Desc { get; set; } // Description
        internal string Path { get; set; } // Directory path
        internal int SScore { get; set; } // Search score
        internal Panel Pnl { get; set; }
    }
}
