using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace Streaming
{
    public static class Videos
    {
        public static List<Video> videoList = new List<Video>();
        static Videos() // Get the videos from list.json
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings { MaxDepth = 128 };
            Directory.CreateDirectory(@"videos");
            if (!File.Exists(@"videos\list.json"))
            {
                FileStream str = File.Create(@"videos\list.json"); // Create the lists.json if not exist
                str.Close();
                File.WriteAllText(@"videos\list.json", JsonConvert.SerializeObject(new List<Video>(), Formatting.Indented));
            }
            string vids = File.ReadAllText(@"videos\list.json");
            List<Video> vidsL_Conv = JsonConvert.DeserializeObject<List<Video>>(vids);
            videoList = vidsL_Conv;

            List<string> paths = vidsL_Conv != null ? videoList.ConvertAll(x => x.Path) : new List<string>(); // Get paths from the list

            foreach (string file in Directory.EnumerateFiles("videos")) // Add videos from the videos folder
            {
                if (!".mp4.avi.mov.webm.flv.wmv.mpeg4".Contains(Path.GetExtension(file))) continue;
                if (!paths.Contains(file))
                {
                    File.Delete(file);
                }
            }
        }

        public static void Save() // Save the videos into list.json
        {
            string json = JsonConvert.SerializeObject(videoList, Formatting.Indented);
            File.WriteAllText(@"videos\list.json", json);
        }
    }
}
