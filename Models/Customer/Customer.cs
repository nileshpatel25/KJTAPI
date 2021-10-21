using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KJT.Models.Customer
{
    public class Customers
    {
        public string name { get; set; }
        public string address { get; set; }
        public string mobileno { get; set; }
        public string emailid { get; set; }
    }
    public class CustomerStatus
    {
        public int Status { get; set; }
        public string Message { get; set; }
    }
}