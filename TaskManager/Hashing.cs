using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace TaskManager
{
    public class Hashing
    {
        public static string PasswordHashing(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (byte b2 in hash)
            {
                sb.Append(b2.ToString("X2"));
            }
            return Convert.ToString(sb);
        }

    }
}
