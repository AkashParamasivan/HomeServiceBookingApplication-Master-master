using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BookingApi.Models
{
    public partial class Booking
    {
        public int Bookingid { get; set; }
        public string CustomerId { get; set; }
        public string ServiceProviderId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Servicedate { get; set; }
        public int Starttime { get; set; }
        public int Endtime { get; set; }
        public int? Estimatedcost { get; set; }
        public bool? Bookingstatus { get; set; }
        public bool? Servicestatus { get; set; }
        public int? Rating { get; set; }

        public Booking()
        { }
        public Booking(int bookid,string custid,string spid,DateTime sdate,int stime,int endtime ,int escost,bool bstatus,bool sstatus,int rating)
        {
            Bookingid = bookid;
            CustomerId = custid;
            ServiceProviderId = spid;
            Servicedate = sdate;
            Starttime = stime;
            Endtime = endtime;
            Estimatedcost = escost;
            Bookingstatus = bstatus;
            Servicestatus = sstatus;
            Rating = rating;
        }

        
    }
}
