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
    }
}
