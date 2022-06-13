using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLHFC.Classes
{
    public class UserDetails
    {
        private static string username;
        private static string tennv;
        private static string diachi;
        private static string sdt;
        public static string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public static string Tennv
        {
            get { return tennv; }
            set { tennv = value; }
        }
        public static string Diachi
        {
            get { return diachi; }
            set { diachi = value; }
        }
        public static string Sdt
        {
            get { return sdt; }
            set { sdt = value; }
        }
    }
}
