using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using KJT.Models.Interface;
using KJT.Models.Customer;

namespace KJT.Controllers
{
    [RoutePrefix("api/kjt")]
    public class AccountController : ApiController
    {
        static readonly ICustomer repository = new Customermaster();
      
        [HttpPost]
        [Route("customermaster")]
        public CustomerStatus insertRegistration(Customers regi)
        {
            return repository.insertRegistration(regi);
        }
    }
}
