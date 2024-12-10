using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Threading;
using System.Web.Http;
using WebApiJson.Models;


namespace WebApiJson.Controllers
{

    public class JsonApiController : ApiController
    {
        string str;
        SqlCommand cmd = new SqlCommand();
        SqlConnection con;



        //public HttpResponseMessage Login(Userlogin userlogin)
        //{
        //    tabular_UATEntities db = new tabular_UATEntities();
        //    var list = db.Userlogins.ToList();
        //    var check = db.Userlogins.Where(Model => Model.UserName == userlogin.UserName && Model.Password == userlogin.Password).FirstOrDefault();
        //    if (check != null)
        //    {
        //        //post();
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("Statuscode");
        //        dt.Columns.Add("Messege");
        //        dt.Columns.Add("DateTime");

        //        dt.Rows.Add("S01", "Authentication Success", DateTime.Now);

        //        return Request.CreateResponse(HttpStatusCode.OK, dt);
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


        #region getdatafromapi
        //[BasicAuthenticate]
        //[HttpPost]
        //public HttpResponseMessage post()
        //{
        //    IEnumerable<CFTdata_ivy> CFTdata_ivys = null;
        //    var t = DateTime.Now;

        //    {


        //        using (var client = new HttpClient())
        //        {
        //            //client.BaseAddress = new Uri("http://localhost:61549/Api/cftdata/GetRecord");
        //            //client.BaseAddress = new Uri("http://localhost/Api/cftdata/GetRecord");

        //            client.BaseAddress = new Uri("https://zwapp.zyduscadila.com/DummyAPI/api/cftdata/getrecord");

        //            var responseTask = client.GetAsync("CFTdata_ivy");
        //            responseTask.Wait();

        //            var result = responseTask.Result;
        //            if (result.IsSuccessStatusCode)
        //            {
        //                var readTask = result.Content.ReadAsAsync<IList<CFTdata_ivy>>();
        //                readTask.Wait();

        //                CFTdata_ivys = readTask.Result;
        //                try
        //                {

        //                    str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //                    con = new SqlConnection(str);

        //                        con.Open();
        //                    foreach (var s in CFTdata_ivys)
        //                    {

        //                        if (s.DivisionName == null)
        //                        {

        //                            DataTable dt3 = new DataTable();
        //                            dt3.Columns.Add("Statuscode");
        //                            dt3.Columns.Add("Messege");
        //                            dt3.Columns.Add("DateTime");

        //                            dt3.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //                            DataTable dtbl3 = new DataTable();
        //                            dtbl3.Columns.Add("Statuscode");
        //                            dtbl3.Columns.Add("Messege");
        //                            dtbl3.Columns.Add("DateTime");
        //                            dtbl3.Rows.Add("S01", "Authentication Success", t);
        //                            dtbl3.AcceptChanges();
        //                            dtbl3.Merge(dt3, false, MissingSchemaAction.Add);
        //                            return Request.CreateResponse(HttpStatusCode.OK, dtbl3);

        //                        }

        //                            // cmd = new SqlCommand("Insertinto CFTdata_ivy(DivisionName,	VPsalesCode,VPsalesName,SalesHeadcode,SalesHeadName,ZonalHeadCode,ZonalHeadName,AreaHeadCode,AreaHeadName,Date,DistributorCode,DistributorName,DSRCode,DSRName,RouteCode,RouteName,	CustomerCode,CustomerName,Timein,Timeout,TimeSpent,TimeSpent_Sec,PlannedorDeviated,Orderid,OrderValue	,TLSD,SyncDate,SyncTime,Reason,Latitude,Longitude,GeoFencingDevReason,ReceivedON) Values((s.DivisionName, s.VPsalesCode, s.VPsalesName, s.SalesHeadcode, s.SalesHeadName, s.ZonalHeadCode,s.ZonalHeadName, s.AreaHeadCode, s.AreaHeadName, s.Date, s.DistributorCode, s.DistributorName, s.DSRCode, s.DSRName,s.RouteCode, s.RouteName, s.CustomerCode, s.CustomerName, s.Timein, s.Timeout, s.TimeSpent, s.TimeSpent_Sec, s.PlannedorDeviated,s.Orderid, s.OrderValue  , s.TLSD, s.SyncDate, s.SyncTime, s.Reason, s.Latitude, s.Longitude, s.GeoFencingDevReason, DateTime.Now)", con);


        //                            cmd = new SqlCommand("insert into CFTdata_ivy values('" + s.DivisionName + "','" + s.VPsalesCode + "','" + s.VPsalesName + "','" + s.SalesHeadcode + "','" + s.SalesHeadName + "','" + s.ZonalHeadCode + "','" + s.ZonalHeadName + "','" + s.AreaHeadCode + "','" + s.AreaHeadName + "','" + Convert.ToDateTime(s.Date).ToString("yyyy-MM-dd HH:mm:ss") + "','" + s.DistributorCode + "','" + s.DistributorName + "','" + s.DSRCode + "','" + s.DSRName + "','" + s.RouteCode + "','" + s.RouteName + "','" + s.CustomerCode + "','" + s.CustomerName + "','" + TimeSpan.Parse((s.Timein).ToString()) + "','" + TimeSpan.Parse((s.Timeout).ToString()) + "','" + TimeSpan.Parse((s.TimeSpent).ToString()) + "','" + Convert.ToDouble(s.TimeSpent_Sec) + "','" + s.PlannedorDeviated + "','" + s.Orderid + "','" + Convert.ToDecimal(s.OrderValue) + "','" + Convert.ToInt32(s.TLSD) + "','" + Convert.ToDateTime(s.SyncDate).ToString("yyyy-MM-dd HH:mm:ss") + "','" + TimeSpan.Parse((s.SyncTime).ToString())
        //                               + "','" + s.Reason + "','" + s.Latitude + "','" + s.Longitude + "','" + s.GeoFencingDevReason + "','" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "','" + s.seller_type + "')", con);


        //                            //cmd = new SqlCommand("insert into stud2 values('" + students.Select(s => s.sname) + "','" + students.Select(s => s.marks) + "')", con);
        //                            int a = cmd.ExecuteNonQuery();

        //                    }

        //                    con.Close();

        //                    DataTable dt = new DataTable();
        //                    dt.Columns.Add("Statuscode");
        //                    dt.Columns.Add("Messege");
        //                    dt.Columns.Add("DateTime");

        //                    dt.Rows.Add("S01", "Data uploaded Successfully", DateTime.Now);

        //                    DataTable dtbl = new DataTable();
        //                    dtbl.Columns.Add("Statuscode");
        //                    dtbl.Columns.Add("Messege");
        //                    dtbl.Columns.Add("DateTime");
        //                    dtbl.Rows.Add("S01", "Authentication Success", t);
        //                    dtbl.AcceptChanges();
        //                    dtbl.Merge(dt, false, MissingSchemaAction.Add);


        //                    return Request.CreateResponse(HttpStatusCode.OK, dtbl);
        //                }
        //                catch (Exception)
        //                {

        //                    DataTable dt2 = new DataTable();
        //                    dt2.Columns.Add("Statuscode");
        //                    dt2.Columns.Add("Messege");
        //                    dt2.Columns.Add("DateTime");

        //                    dt2.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //                    DataTable dtbl2 = new DataTable();
        //                    dtbl2.Columns.Add("Statuscode");
        //                    dtbl2.Columns.Add("Messege");
        //                    dtbl2.Columns.Add("DateTime");
        //                    dtbl2.Rows.Add("S01", "Authentication Success", t);
        //                    dtbl2.AcceptChanges();
        //                    dtbl2.Merge(dt2, false, MissingSchemaAction.Add);
        //                    return Request.CreateResponse(HttpStatusCode.OK, dtbl2);
        //                }
        //                finally
        //                {
        //                    con.Close();
        //                }

        //            }
        //        }

        //        DataTable dt1 = new DataTable();
        //        dt1.Columns.Add("Statuscode");
        //        dt1.Columns.Add("Messege");
        //        dt1.Columns.Add("DateTime");

        //        dt1.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //        DataTable dtbl1 = new DataTable();
        //        dtbl1.Columns.Add("Statuscode");
        //        dtbl1.Columns.Add("Messege");
        //        dtbl1.Columns.Add("DateTime");
        //        dtbl1.Rows.Add("S01", "Authentication Success", t);
        //        dtbl1.AcceptChanges();
        //        dtbl1.Merge(dt1, false, MissingSchemaAction.Add);


        //        return Request.CreateResponse(HttpStatusCode.OK, dtbl1);


        //    }
        //}


        #endregion
        [BasicAuthenticate]
        public HttpResponseMessage Get()
        {

            string userName = Thread.CurrentPrincipal.Identity.Name;
            using (tabular_UATEntities entities = new tabular_UATEntities())
            {
                if (userName != "")
                {
                    string name = entities.Userlogins.Select(x => x.UserName).Take(1).FirstOrDefault();
                    if (name == "MaUser")
                    {
                        Userlogin userlogin = new Userlogin();
                        //Login(userlogin);
                        // post();
                    }
                    return Request.CreateResponse(HttpStatusCode.OK, "Plese login");

                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }

        }


        #region ManualyPushData
        public HttpResponseMessage post(CFTdata_ivy cFTdata_ivy)
        {
            Data1 data = new Data1();
            IEnumerable<Data1> CFTdata_ivys = cFTdata_ivy.Data;
            tabular_UATEntities db = new tabular_UATEntities();
            var t = DateTime.Now;
            string str;
            SqlCommand cmd = new SqlCommand();
            SqlConnection con;
            //var User = cFTdata_ivy.Select(s1 => s1.UserName).ToList().Intersect(db.Userlogins.Select(s2 => s2.UserName).ToList()).ToList();
            //var Pass = cFTdata_ivy.Select(s1 => s1.Password).ToList().Intersect(db.Userlogins.Select(s2 => s2.Password).ToList()).ToList();


            var check = db.Userlogins.Where(Model => Model.UserName == cFTdata_ivy.UserName && Model.Password == cFTdata_ivy.Password).FirstOrDefault();

            if (check != null)

            {

                str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
                con = new SqlConnection(str);

                try
                {

                    con.Open();
                    foreach (var s in CFTdata_ivys)
                    {
                        if (s.DivisionName == null || s.DivisionName == "" || s.CustomerCode == "" || s.CustomerName == "" || s.RouteCode == "" || s.RouteName == "" || s.DSRName == "" || s.DSRCode == "" || s.DistributorCode == "" || s.DistributorName == "" || s.Date == null || s.SyncDate == null)
                        {

                            DataTable dt3 = new DataTable();
                            dt3.Columns.Add("Statuscode");
                            dt3.Columns.Add("Messege");
                            dt3.Columns.Add("DateTime");

                            dt3.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

                            DataTable dtbl3 = new DataTable();
                            dtbl3.Columns.Add("Statuscode");
                            dtbl3.Columns.Add("Messege");
                            dtbl3.Columns.Add("DateTime");
                            dtbl3.Rows.Add("S01", "Authentication Success", t);
                            dtbl3.AcceptChanges();
                            dtbl3.Merge(dt3, false, MissingSchemaAction.Add);
                            return Request.CreateResponse(HttpStatusCode.OK, dtbl3);
                        }

                        cmd = new SqlCommand("insert into CFTdata_ivy values('" + s.DivisionName + "','" + s.VPsalesCode + "','" + s.VPsalesName + "','" + s.SalesHeadcode + "','" + s.SalesHeadName + "','" + s.ZonalHeadCode + "','" + s.ZonalHeadName + "','" + s.AreaHeadCode + "','" + s.AreaHeadName + "','" + Convert.ToDateTime(s.Date).ToString("yyyy-MM-dd HH:mm:ss") + "','" + s.DistributorCode + "','" + s.DistributorName + "','" + s.DSRCode + "','" + s.DSRName + "','" + s.RouteCode + "','" + s.RouteName + "','" + s.CustomerCode + "','" + s.CustomerName + "','" + TimeSpan.Parse((s.Timein).ToString()) + "','" + TimeSpan.Parse((s.Timeout).ToString()) + "','" + TimeSpan.Parse((s.TimeSpent).ToString()) + "','" + Convert.ToDouble(s.TimeSpent_Sec) + "','" + s.PlannedorDeviated + "','" + s.Orderid + "','" + Convert.ToDecimal(s.OrderValue) + "','" + Convert.ToInt32(s.TLSD) + "','" + Convert.ToDateTime(s.SyncDate).ToString("yyyy-MM-dd HH:mm:ss") + "','" + TimeSpan.Parse((s.SyncTime).ToString())
                                          + "','" + s.Reason + "','" + s.Latitude + "','" + s.Longitude + "','" + s.GeoFencingDevReason + "','" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "','" + s.SellerType + "')", con);
                        cmd.ExecuteNonQuery();
                    }
                    con.Close();
                    DataTable dt = new DataTable();
                    dt.Columns.Add("Statuscode");
                    dt.Columns.Add("Messege");
                    dt.Columns.Add("DateTime");

                    dt.Rows.Add("S01", "Data uploaded Successfully", DateTime.Now);

                    DataTable dtbl = new DataTable();
                    dtbl.Columns.Add("Statuscode");
                    dtbl.Columns.Add("Messege");
                    dtbl.Columns.Add("DateTime");
                    dtbl.Rows.Add("S01", "Authentication Success", t);
                    dtbl.AcceptChanges();
                    dtbl.Merge(dt, false, MissingSchemaAction.Add);


                    return Request.CreateResponse(HttpStatusCode.OK, dtbl);
                }
                catch
                {
                    DataTable dt2 = new DataTable();
                    dt2.Columns.Add("Statuscode");
                    dt2.Columns.Add("Messege");
                    dt2.Columns.Add("DateTime");

                    dt2.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

                    DataTable dtbl2 = new DataTable();
                    dtbl2.Columns.Add("Statuscode");
                    dtbl2.Columns.Add("Messege");
                    dtbl2.Columns.Add("DateTime");
                    dtbl2.Rows.Add("S01", "Authentication Success", t);
                    dtbl2.AcceptChanges();
                    dtbl2.Merge(dt2, false, MissingSchemaAction.Add);
                    return Request.CreateResponse(HttpStatusCode.OK, dtbl2);

                }

            }

            else
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Statuscode");
                dt.Columns.Add("Messege");
                dt.Columns.Add("DateTime");

                dt.Rows.Add("E01", "Authentication Faild", DateTime.Now);
                return Request.CreateResponse(HttpStatusCode.OK, dt);
            }


        }
        #endregion

        #region DatapushbybasicAuthentication

        // [BasicAuthenticate]
        //[HttpPost]
        //public HttpResponseMessage post(IEnumerable<CFTdata_ivy> cFTdata_ivy)
        //{
        //    IEnumerable<CFTdata_ivy> CFTdata_ivys = cFTdata_ivy;
        //    tabular_UATEntities db = new tabular_UATEntities();
        //    var t = DateTime.Now;
        //    string str;
        //    SqlCommand cmd = new SqlCommand();
        //    SqlConnection con;

        //    str = ConfigurationManager.ConnectionStrings["constr"].ConnectionString;
        //    con = new SqlConnection(str);

        //    try
        //    {

        //        con.Open();
        //        foreach (var s in CFTdata_ivys)
        //        {
        //            if (s.DivisionName == null)
        //            {

        //                DataTable dt3 = new DataTable();
        //                dt3.Columns.Add("Statuscode");
        //                dt3.Columns.Add("Messege");
        //                dt3.Columns.Add("DateTime");

        //                dt3.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //                DataTable dtbl3 = new DataTable();
        //                dtbl3.Columns.Add("Statuscode");
        //                dtbl3.Columns.Add("Messege");
        //                dtbl3.Columns.Add("DateTime");
        //                dtbl3.Rows.Add("S01", "Authentication Success", t);
        //                dtbl3.AcceptChanges();
        //                dtbl3.Merge(dt3, false, MissingSchemaAction.Add);
        //                return Request.CreateResponse(HttpStatusCode.OK, dtbl3);
        //            }

        //            cmd = new SqlCommand("insert into CFTdata_ivy values('" + s.DivisionName + "','" + s.VPsalesCode + "','" + s.VPsalesName + "','" + s.SalesHeadcode + "','" + s.SalesHeadName + "','" + s.ZonalHeadCode + "','" + s.ZonalHeadName + "','" + s.AreaHeadCode + "','" + s.AreaHeadName + "','" + Convert.ToDateTime(s.Date).ToString("yyyy-MM-dd HH:mm:ss") + "','" + s.DistributorCode + "','" + s.DistributorName + "','" + s.DSRCode + "','" + s.DSRName + "','" + s.RouteCode + "','" + s.RouteName + "','" + s.CustomerCode + "','" + s.CustomerName + "','" + TimeSpan.Parse((s.Timein).ToString()) + "','" + TimeSpan.Parse((s.Timeout).ToString()) + "','" + TimeSpan.Parse((s.TimeSpent).ToString()) + "','" + Convert.ToDouble(s.TimeSpent_Sec) + "','" + s.PlannedorDeviated + "','" + s.Orderid + "','" + Convert.ToDecimal(s.OrderValue) + "','" + Convert.ToInt32(s.TLSD) + "','" + Convert.ToDateTime(s.SyncDate).ToString("yyyy-MM-dd HH:mm:ss") + "','" + TimeSpan.Parse((s.SyncTime).ToString())
        //                              + "','" + s.Reason + "','" + s.Latitude + "','" + s.Longitude + "','" + s.GeoFencingDevReason + "','" + (DateTime.Now).ToString("yyyy-MM-dd hh:mm:ss") + "','" + s.seller_type + "')", con);
        //            cmd.ExecuteNonQuery();
        //        }
        //        con.Close();
        //        DataTable dt = new DataTable();
        //        dt.Columns.Add("Statuscode");
        //        dt.Columns.Add("Messege");
        //        dt.Columns.Add("DateTime");

        //        dt.Rows.Add("S01", "Data uploaded Successfully", DateTime.Now);

        //        DataTable dtbl = new DataTable();
        //        dtbl.Columns.Add("Statuscode");
        //        dtbl.Columns.Add("Messege");
        //        dtbl.Columns.Add("DateTime");
        //        dtbl.Rows.Add("S01", "Authentication Success", t);
        //        dtbl.AcceptChanges();
        //        dtbl.Merge(dt, false, MissingSchemaAction.Add);


        //        return Request.CreateResponse(HttpStatusCode.OK, dtbl);
        //    }
        //    catch
        //    {
        //        DataTable dt2 = new DataTable();
        //        dt2.Columns.Add("Statuscode");
        //        dt2.Columns.Add("Messege");
        //        dt2.Columns.Add("DateTime");

        //        dt2.Rows.Add("E01", "Uanable to Upload the Data", DateTime.Now);

        //        DataTable dtbl2 = new DataTable();
        //        dtbl2.Columns.Add("Statuscode");
        //        dtbl2.Columns.Add("Messege");
        //        dtbl2.Columns.Add("DateTime");
        //        dtbl2.Rows.Add("S01", "Authentication Success", t);
        //        dtbl2.AcceptChanges();
        //        dtbl2.Merge(dt2, false, MissingSchemaAction.Add);
        //        return Request.CreateResponse(HttpStatusCode.OK, dtbl2);

        //    }



        //    //DataTable dt = new DataTable();
        //    //dt.Columns.Add("Statuscode");
        //    //        dt.Columns.Add("Messege");
        //    //        dt.Columns.Add("DateTime");

        //    //        dt.Rows.Add("E01", "Authentication Faild", DateTime.Now);
        //    return Request.CreateResponse(HttpStatusCode.OK);


        //}



        #endregion

        public HttpResponseMessage postdata(CFTdata_ivy cFTdata_ivy)
        {

            SaveExceptionlog("Execution started for postdata", "JsonAPIController::newpost", "CodeType");
            ResponseModel res = new ResponseModel();

            res.statuscode = "E01";
            res.message = "Not Found";
            try
            {
                if (cFTdata_ivy != null)
                {
                    SaveExceptionlog("Postdata received successfully", "JsonAPIController::newpost", "CodeType");
                    tabular_UATEntities db = new tabular_UATEntities();
                    var usr = db.Userlogins.Where(x => x.UserName == cFTdata_ivy.UserName && x.Password == cFTdata_ivy.Password).FirstOrDefault();
                    if (usr == null)
                    {
                        res.statuscode = "E01";
                        res.message = "Invalid User Credentails";
                        SaveExceptionlog(res.message, "JsonAPIController::newpost", "CodeType");

                    }
                    else
                    {

                        var count = 0;
                        
                    var duplicates = 0;
                        var rowID_Exists = false;
                        IEnumerable<Data1> CFTdata_ivys = cFTdata_ivy.Data;
                        duplicates = CFTdata_ivys.GroupBy(x => x.RowId).Where(g => g.Count() > 1).Count();
                        rowID_Exists=CFTdata_ivys.Any(x => string.IsNullOrWhiteSpace(x.RowId));

                        if (rowID_Exists)
                        {
                        res.statuscode = "E01";
                        res.message = "Record set is missing with RowID";
                        SaveExceptionlog(res.message, "JsonAPIController::newpost", "CodeType");
                        return Request.CreateResponse(HttpStatusCode.OK, res);
                        }
                        
                        count = CFTdata_ivys.Where(x => x.DivisionName == "" || x.DivisionName == null ||
                        x.CustomerCode == "" || x.CustomerCode == null ||
                        x.CustomerName == "" || x.CustomerCode == null ||
                        //x.RouteCode == "" || x.RouteCode == null ||
                        //x.RouteName == "" || x.RouteName == null ||
                        x.DSRName == "" || x.DSRName == null ||
                        x.DSRCode == "" || x.DSRCode == null ||
                        x.DistributorCode == "" || x.DistributorCode == null ||
                        x.DistributorName == "" || x.DistributorName == null ||
                        x.Date == null || x.SyncDate == null || x.RowId==null || x.RowId=="").Count();

                        if (duplicates > 0)
                        {
                            res.statuscode = "E01";
                            res.message = "Record set contains duplicate records";
                            SaveExceptionlog(res.message, "JsonAPIController::newpost", "CodeType");
                            return Request.CreateResponse(HttpStatusCode.OK, res);
                        }

                        if (count > 0)
                        {
                             res.statuscode = "E01";
                             res.message = "RowID, DivisionName,CustomerCode,CustomerName,RouteCode,RouteName,DSRName,DSRCode,DistributorCode,DistributorName,SyncDate,Date column cannot be null";
                             SaveExceptionlog(res.message, "JsonAPIController::newpost", "CodeType");
                             return Request.CreateResponse(HttpStatusCode.OK, res);
                        }


                        DataTable dt = ToDataTable(CFTdata_ivys.ToList());
                        DataTable dtresult = new DataTable();

                        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
                        con.Open();
                        SqlCommand cmd = new SqlCommand("usp_CFTdata_ivy", con);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@dt", dt);

                        SqlDataAdapter sda = new SqlDataAdapter(cmd);
                        sda.Fill(dtresult);
                        con.Close();

                        if (dtresult.Rows.Count > 0)
                        {
                            if ((string)dtresult.Rows[0]["statuscode"] == "S01")
                            {

                                res.statuscode = (string)dtresult.Rows[0]["statuscode"];
                                res.message = (string)dtresult.Rows[0]["message"];
                                SaveExceptionlog(res.message, "JsonAPIController::newpost", "CodeType");
                                return Request.CreateResponse(HttpStatusCode.OK, res);
                            }
                        }
                    }

                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
            }
            catch (Exception ex)
            {

                res.message = ex.Message.ToString();
                res.statuscode = "E01";
                SaveExceptionlog(ex.Message.ToString(), "JsonAPIController::newpost", "CodeType");
                return Request.CreateResponse(HttpStatusCode.NotFound, res);

            }

            return Request.CreateResponse(HttpStatusCode.OK, res);

        }


        //-------------

        [NonAction]
        public void SaveExceptionlog(string message = null, string source = null, string type = null)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
            con.Open();
            SqlCommand cmd = new SqlCommand("usp_exception_log", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@message", message);
            cmd.Parameters.AddWithValue("@source", source);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.ExecuteNonQuery();
        }
        //-------------
        [NonAction]
        public DataTable ToDataTable<T>(List<T> items)
        {
            DataTable dataTable = new DataTable(typeof(T).Name);
            //Get all the properties
            PropertyInfo[] Props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            foreach (PropertyInfo prop in Props)
            {
                //Setting column names as Property names
                dataTable.Columns.Add(prop.Name);
            }
            foreach (T item in items)
            {
                var values = new object[Props.Length];
                for (int i = 0; i < Props.Length; i++)
                {
                    //inserting property values to datatable rows
                    values[i] = Props[i].GetValue(item, null);
                }
                dataTable.Rows.Add(values);
            }
            //put a breakpoint here and check datatable
            return dataTable;
        }

    }

}

