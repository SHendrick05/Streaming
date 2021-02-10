using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Streaming
{
    static class AccSecurity
    {
        //
        // Random generation
        //
        private static RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
        public static string genText(int len)
        {
            string valid = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM0123456789!$% ^&*()[];'#,./{}:@~<>?'";
            StringBuilder res = new StringBuilder();
            byte[] Buffer = new byte[sizeof(uint)];
            while(len-- > 0)
            {
                rngCsp.GetBytes(Buffer);
                uint num = BitConverter.ToUInt32(Buffer, 0);
                res.Append(valid[(int)(num % (uint)valid.Length)]);
            }

            return res.ToString();
        }
        

        // 
        // Hashes
        //

        public static string Hashval(string input)
        {
            using(SHA256 mySha = SHA256.Create())
            {
                byte[] inputB = Encoding.Default.GetBytes(input); // Convert the input into bytes

                byte[] result = mySha.ComputeHash(inputB); // Hash the value

                string outputS = Encoding.Default.GetString(result); // Convert output into a string

                return outputS;
            }
        }
    }
}
