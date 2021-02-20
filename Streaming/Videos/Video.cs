using Microsoft.WindowsAPICodePack.Shell;
using System.Drawing;
using System.Windows.Forms;

namespace Streaming
{
    public class Video // Video class to use
    {
        public Video(string pth, string Title, string dsc, string user, bool adult = false) // Constructor
        {
            this.Title = Title;
            Desc = dsc;
            Path = pth;
            Likes = 0;
            Dislikes = 0;
            Views = 0;
            AdultOnly = adult;
            uploader = user;
        }

        public uint Views { get; set; }
        internal Bitmap Thumbnail { get
            {
                ShellFile shellFile = ShellFile.FromFilePath(Path); // Generate thumbnail 
                return shellFile.Thumbnail.Bitmap;
            }
        }
        public string Title { get; set; }
        public string Desc { get; set; } // Description
        public string Path { get; set; }
        internal int SScore { get; set; } // Search score
        internal Panel Pnl { get; set; }
        public uint Likes { get; set; }
        public uint Dislikes { get; set; }
        public bool AdultOnly { get; set; }
        public string uploader { get; set; }
        internal double LR_Ratio
        { get
            {
                return Likes / (Likes + Dislikes);
            } }
    }
}
