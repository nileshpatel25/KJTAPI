using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using KJT.Models.Customer;


namespace KJT.Models.Interface
{
    interface ICustomer
    {
        CustomerStatus insertRegistration(Customers regi);
    }
}
