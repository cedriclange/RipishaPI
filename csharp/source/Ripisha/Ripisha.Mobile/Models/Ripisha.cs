using System;
using System.Collections.Generic;
using System.Text;

namespace Ripisha.Mobile.Models
{
    //this class is the object model 
    //to be mapped in the database
    public class Ripisha
    {
        public int Id { get; set; }
        public TransType TransType { get; set; }
        public string TransId { get; set; }
        public DateTime Time { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public int Status { get; set; }
        public long Amount { get; set; }
        public Currency Currency { get; set; }
        public long PostBalance { get; set; }
        public string Note { get; set; }
    }
     public enum Currency { USD, CDF}
     public enum TransType { IN, OUT}
}
