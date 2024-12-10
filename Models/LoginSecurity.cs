using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;

namespace WebApiJson.Models
{
    public class LoginSecurity
    {

        public static bool login(string username, string password)
        {
            using (tabular_UATEntities db = new tabular_UATEntities())
            {
                var check = db.Userlogins.Any(model => model.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
                 && model.Password == password);
                return check;
            }
        }
       
    }
}