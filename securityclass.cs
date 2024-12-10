using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiJson.Models;

namespace WebApiJson
{
    public class EmployeeSecurity1
    {
        public bool vailidateUser(string username, string password)
        {

            {

                tabular_UATEntities db = new tabular_UATEntities();
                Userlogin userlogin = new Userlogin();
                var list = db.Userlogins.ToList();
                var check = db.Userlogins.Where(Model => Model.UserName == userlogin.UserName && Model.Password == userlogin.Password).FirstOrDefault();
                if (check != null)
                {
                    return true;
                }
                return false;
            }

        }
    }
}