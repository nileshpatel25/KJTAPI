using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KJT.Models.Login
{
    public class Logins
    {
       
            public string username { get; set; }
            public string password { get; set; }

       
       
    }
    public class LoginStatus
    {
        public int Status { get; set; }
        public string Message { get; set; }

        public object userinfo { get; set; }
    }
}