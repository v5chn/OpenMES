//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MES.Persistency
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductKeyIDSerialNumberPairs
    {
        public System.Guid PairID { get; set; }
        public string TransactionID { get; set; }
        public Nullable<long> ProductKeyID { get; set; }
        public string SerialNumber { get; set; }
        public string SeriesID { get; set; }
        public string SeriesName { get; set; }
        public string ModelID { get; set; }
        public string ModelName { get; set; }
        public string DeviceID { get; set; }
        public string DeviceName { get; set; }
        public string OperatorID { get; set; }
        public string OperatorName { get; set; }
        public string StationID { get; set; }
        public string StationName { get; set; }
        public string LineID { get; set; }
        public string LineName { get; set; }
        public string BusinessID { get; set; }
        public string BusinessName { get; set; }
        public string OrderID { get; set; }
        public Nullable<int> ReadCount { get; set; }
        public Nullable<System.DateTime> CreationTime { get; set; }
        public Nullable<System.DateTime> ModificationTime { get; set; }
        public string Remarks { get; set; }
    }
}
