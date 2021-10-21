using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KJT.Models.Login;
namespace KJT.Models.Interface
{
    interface ILogin
    {
        LoginStatus loginprocess(Logins login);

    }
}
