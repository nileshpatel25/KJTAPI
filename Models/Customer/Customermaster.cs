using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KJT.Models.Interface;
using KJT.Models.Common;
using System.Data.SqlClient;

namespace KJT.Models.Customer
{
    public class Customermaster : ICustomer
    {
        public CustomerStatus insertRegistration(Customers regi)
        {
            try
            {
                DbConnection con = new DbConnection();
                SqlParameter[] para = { new SqlParameter("@name",regi.name),
                                         new SqlParameter("@address",regi.address),
                                         new SqlParameter("@mobileno",regi.mobileno),
                                         new SqlParameter("@emailid",regi.emailid),
                                        };
                int i = 0;
                i = Convert.ToInt32(con.GetExecutenonQuery("insertRegistration", para));
                CustomerStatus val = new CustomerStatus();
                val.Status = 1;
                val.Message = "Registration Successfully";
                return val;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}