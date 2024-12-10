using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApiJson.Models
{
    public class Data1
    {
       
       // public int ID { get; set; }
        public string DivisionName { get; set; }
        public string VPsalesCode { get; set; }
        public string VPsalesName { get; set; }
        public string SalesHeadcode { get; set; }
        public string SalesHeadName { get; set; }
        public string ZonalHeadCode { get; set; }
        public string ZonalHeadName { get; set; }
        public string AreaHeadCode { get; set; }
        public string AreaHeadName { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
      
       // public DateTime Date { get; set; }
        public string DistributorCode { get; set; }
        public string DistributorName { get; set; }
        public string DSRCode { get; set; }
        public string DSRName { get; set; }
        public string RouteCode { get; set; }
        public string RouteName { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public System.TimeSpan Timein { get; set; }
        public System.TimeSpan Timeout { get; set; }
        public System.TimeSpan TimeSpent { get; set; }
        public long TimeSpent_Sec { get; set; }
        public string PlannedorDeviated { get; set; }
        public string Orderid { get; set; }
        public decimal OrderValue { get; set; }
        public int TLSD { get; set; }
       public Nullable<System.DateTime> SyncDate { get; set; }
        //public DateTime SyncDate { get; set; }
        public System.TimeSpan SyncTime { get; set; }
        public string Reason { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string GeoFencingDevReason { get; set; }
       // public System.DateTime ReceivedON { get; set; }
        public string GeoFencingDevRemarks { get; set; }
        public string RowId { get; set; } = "";
        public string SellerType { get; set; }
    }
}