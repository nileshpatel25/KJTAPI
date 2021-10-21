using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KJT.Models.Interface;
using KJT.Models.Customer;
using KJT.Models.Login;

namespace KJT.Controllers
{
    [RoutePrefix("api/kjt")]
    public class AccountController : ApiController
    {
        static readonly ICustomer repository = new Customermaster();
        static readonly ILogin loginrepo = new LoginMaster();
      
        [HttpPost]
        [Route("customermaster")]
        public CustomerStatus insertRegistration(Customers regi)
        {
            return repository.insertRegistration(regi);
        }

        [HttpPost]
        [Route("loginprocess")]
        public LoginStatus loginprocess(Logins logins)
        {
            return loginrepo.loginprocess(logins);
        }
    }
}
