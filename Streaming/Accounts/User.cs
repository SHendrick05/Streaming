using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streaming
{
    public enum Level
    {
        CHILD,
        ADULT
    }
    public class User
    {
        public User(string uNam, string PWHash, string PWSalt, DateTime BirthDate)
        {
            Username = uNam;
            Hash = PWHash;
            Salt = PWSalt;
            DOB = BirthDate;
            Ratings = new Dictionary<string, lState>();
            foreach(Video vid in Videos.videoList)
            {
                Ratings.Add(vid.Path, lState.NONE);
            }
        }

        public Level access {
            get => (DateTime.Today - DOB).TotalDays > 6570 ? Level.ADULT : Level.CHILD;
        }

        public string Username { get; set; }
        internal string Hash { get; set; }
        internal string Salt { get; set; }
        public DateTime DOB { get; set; }
        public Dictionary<string, lState> Ratings { get; set; }

        public void Rate(Video vid, lState rating)
        {
            Ratings[vid.Path] = rating;
        }
    }
}
