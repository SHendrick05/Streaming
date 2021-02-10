using Microsoft.WindowsAPICodePack.Shell;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Streaming
{
    public class Video // Video class to use
    {
        public Video(string pth, string Title, string dsc, bool adult = false) // Constructor
        {
            this.Title = Title;
            Desc = dsc;
            if (pth != null)
                Path = pth;
            Likes = 0;
            Dislikes = 0;
            Views = 0;
            AdultOnly = adult;
            foreach(User USR in Users.userList)
            {
                USR.Rate(this, lState.NONE);
            }
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
        public string Path { get; set; } // Directory path
        internal int SScore { get; set; } // Search score
        internal Panel Pnl { get; set; }
        public uint Likes { get; set; }
        public uint Dislikes { get; set; }
        public bool AdultOnly { get; set; }
        internal double LR_Ratio
        { get
            {
                return Likes / (Likes + Dislikes);
            } }
    }
}
