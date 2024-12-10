using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using WebApiJson.Models;
using System.Data;



namespace WebApiJson.Controllers
{
    public class LoginController : ApiController
    {
       

        //public HttpResponseMessage post(IEnumerable<CFTdata_ivy> cFTdata_ivy)
        //{
        //    IEnumerable<CFTdata_ivy> CFTdata_ivys = cFTdata_ivy;
        //    tabular_UATEntities db = new tabular_UATEntities();
        //    var t = DateTime.Now;
        //    string str;
        //    SqlCommand cmd = new SqlCommand();
        //    SqlConnection con;
        //    var User = cFTdata_ivy.Select(s1 => s1.UserName).ToList().Intersect(db.Userlogins.Select(s2 => s2.UserName).ToList()).ToList();
        //    var Pass = cFTdata_ivy.Select(s1 => s1.Password).ToList().Intersect(db.Userlogins.Select(s2 => s2.Password).ToList()).ToList();

        //   if(User.ToList().Count!=0 && Pass.ToList().Count !=0)
          
        //    {

        //        str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //        con = new SqlConnection(str);

        //        try
        //        {

        //            con.Open();
        //            foreach (var s in CFTdata_ivys)
        //            {
        //                if (s.DivisionName == null)
        //                {

        //                    DataTable dt3 = new DataTable();
        //                    dt3.Columns.Add("Statuscode");
        //                    dt3.Columns.Add("Messege");
        //                    dt3.Columns.Add("DateTime");

        //                    dt3.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //                    DataTable dtbl3 = new DataTable();
        //                    dtbl3.Columns.Add("Statuscode");
        //                    dtbl3.Columns.Add("Messege");
        //                    dtbl3.Columns.Add("DateTime");
        //                    dtbl3.Rows.Add("S01", "Authentication Success", t);
        //                    dtbl3.AcceptChanges();
        //                    dtbl3.Merge(dt3, false, MissingSchemaAction.Add);
        //                    return Request.CreateResponse(HttpStatusCode.OK, dtbl3);
        //                }

        //                    cmd = new SqlCommand("insert into CFTdata_ivy values('" + s.DivisionName + "','" + s.VPsalesCode + "','" + s.VPsalesName + "','" + s.SalesHeadcode + "','" + s.SalesHeadName + "','" + s.ZonalHeadCode + "','" + s.ZonalHeadName + "','" + s.AreaHeadCode + "','" + s.AreaHeadName + "','" + Convert.ToDateTime(s.Date).ToString("yyyy-MM-dd HH:mm:ss") + "','" + s.DistributorCode + "','" + s.DistributorName + "','" + s.DSRCode + "','" + s.DSRName + "','" + s.RouteCode + "','" + s.RouteName + "','" + s.CustomerCode + "','" + s.CustomerName + "','" + TimeSpan.Parse((s.Timein).ToString()) + "','" + TimeSpan.Parse((s.Timeout).ToString()) + "','" + TimeSpan.Parse((s.TimeSpent).ToString()) + "','" + Convert.ToDouble(s.TimeSpent_Sec) + "','" + s.PlannedorDeviated + "','" + s.Orderid + "','" + Convert.ToDecimal(s.OrderValue) + "','" + Convert.ToInt32(s.TLSD) + "','" + Convert.ToDateTime(s.SyncDate).ToString("yyyy-MM-dd HH:mm:ss") + "','" + TimeSpan.Parse((s.SyncTime).ToString())
        //                                      + "','" + s.Reason + "','" + s.Latitude + "','" + s.Longitude + "','" + s.GeoFencingDevReason + "','" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "','" + s.seller_type + "')", con);
        //                cmd.ExecuteNonQuery();
        //            }
        //            con.Close();
        //            DataTable dt = new DataTable();
        //            dt.Columns.Add("Statuscode");
        //            dt.Columns.Add("Messege");
        //            dt.Columns.Add("DateTime");

        //            dt.Rows.Add("S01", "Data uploaded Successfully", DateTime.Now);

        //            DataTable dtbl = new DataTable();
        //            dtbl.Columns.Add("Statuscode");
        //            dtbl.Columns.Add("Messege");
        //            dtbl.Columns.Add("DateTime");
        //            dtbl.Rows.Add("S01", "Authentication Success", t);
        //            dtbl.AcceptChanges();
        //            dtbl.Merge(dt, false, MissingSchemaAction.Add);


        //            return Request.CreateResponse(HttpStatusCode.OK, dtbl);
        //        }
        //        catch
        //        {
        //            DataTable dt2 = new DataTable();
        //            dt2.Columns.Add("Statuscode");
        //            dt2.Columns.Add("Messege");
        //            dt2.Columns.Add("DateTime");

        //            dt2.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //            DataTable dtbl2 = new DataTable();
        //            dtbl2.Columns.Add("Statuscode");
        //            dtbl2.Columns.Add("Messege");
        //            dtbl2.Columns.Add("DateTime");
        //            dtbl2.Rows.Add("S01", "Authentication Success", t);
        //            dtbl2.AcceptChanges();
        //            dtbl2.Merge(dt2, false, MissingSchemaAction.Add);
        //            return Request.CreateResponse(HttpStatusCode.OK, dtbl2);

        //        }

        //    }

        //    else
        //    {
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("Statuscode");
        //        dt.Columns.Add("Messege");
        //        dt.Columns.Add("DateTime");

        //        dt.Rows.Add("E01", "Authentication Faild", DateTime.Now);
        //        return Request.CreateResponse(HttpStatusCode.OK, dt);
        //    }

            
        //}





        public string postdata(CFTdata_ivy cFTdata_ivy)
        {
          
        
                //IEnumerable<CFTdata_ivy> CFTdata_ivys = cFTdata_ivy;

                return "ok";
        }
    }


   

}
