using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KJT.Models.Interface;
using KJT.Models.Common;
using System.Data.SqlClient;


namespace KJT.Models.Login
{
    public class LoginMaster: ILogin
    {
        public LoginStatus loginprocess(Logins login)
        {
            try
            {
                DbConnection con = new DbConnection();
                SqlParameter[] para = { new SqlParameter("@stUserName ",login.username),
                                         new SqlParameter("@stPassword ",login.password),
                                       
                                        };
              //  int i = 0;
                var userinfo = con.GetDataTable("loginProcess", para);
                LoginStatus val = new LoginStatus();
                val.Status = 1;
                val.userinfo = userinfo;
                val.Message = "Login Successfully";
                return val;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}