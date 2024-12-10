using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using System.Text;
using WebApiJson.Models;
using System.Threading;
using System.Security.Principal;
using WebApiJson.Controllers;
using System.Data;

namespace WebApiJson
{
    public class BasicAuthenticateAttribute:AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
          

        
            if (actionContext.Request.Headers.Authorization == null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);

            }
            else
            {
                string authenticationToken = actionContext.Request.Headers.Authorization.Parameter;
                string decodedAuthenticationToken = Encoding.UTF8.GetString(Convert.FromBase64String(authenticationToken));
                string[] usernamePasswordArray = decodedAuthenticationToken.Split(':');
                string username = usernamePasswordArray[0];
                string password = usernamePasswordArray[1];
                if (LoginSecurity.login(username, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Statuscode");
                    dt.Columns.Add("Messege");
                    dt.Columns.Add("DateTime");

                    dt.Rows.Add("E01", "Authentication Faild", DateTime.Now);


                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.OK,dt);
                }
            }
        
        }
    }
}