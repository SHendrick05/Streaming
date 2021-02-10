using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Streaming
{

    public static class Users
    {
        public static List<User> userList = new List<User>();
        public const string fPath = @"accounts\users.json";

        static Users()
        {
            Directory.CreateDirectory("accounts");
            if (!File.Exists(fPath));
            {
                FileStream str = File.Create(fPath); // Create the lists.json if not exist
                str.Close();
                File.WriteAllText(fPath, JsonConvert.SerializeObject(new List<User>(), Formatting.Indented));
            }
            string users = File.ReadAllText(fPath);
            userList = JsonConvert.DeserializeObject<List<User>>(users);
        }

        public static void Save()
        {
            string json = JsonConvert.SerializeObject(userList, Formatting.Indented);
            File.WriteAllText(fPath, json);
        }

        
    }
    

}
