using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiJson.Models;
namespace WebApiJson
{
    public class EmployeeSecurity
    {
        public bool Login(string username, string password)
        {

            //DemoEntities userBL = new DemoEntities();
            //             return userBL.userlogin2.Any(user =>
            //     user.UserName.Equals(username, StringComparison.OrdinalIgnoreCase)
            //     && user.Password == password);
            using (tabular_UATEntities entity = new tabular_UATEntities())
            {
                return entity.Userlogins.Any(x => x.UserName.Equals(username, StringComparison.OrdinalIgnoreCase) && x.Password == password);
            }
        }
    }
}