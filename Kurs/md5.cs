using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Kurs.Connection
{

    internal class md5
    {
        public static string HashPassword(string password)
        {
            MD5 md5 = MD5.Create();

            byte[] b = Encoding.ASCII.GetBytes(password);
            byte[] hash = md5.ComputeHash(b);

            StringBuilder sb = new StringBuilder();
            foreach (var a in hash)

                sb.Append(a.ToString("X2"));
            return Convert.ToString(sb);

        }
    }
    internal class md5l
    {
        public static string Hashlog(string login)
        {
            MD5 md5l = MD5.Create();

            byte[] bl = Encoding.ASCII.GetBytes(login);
            byte[] hashl = md5l.ComputeHash(bl);

            StringBuilder sbl = new StringBuilder();
            foreach (var al in hashl)

                sbl.Append(al.ToString("X2"));
            return Convert.ToString(sbl);

        }
    }
}
