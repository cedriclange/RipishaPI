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
        public int Type { get; set; }
        public string Receipt { get; set; }
        public DateTime Time { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Account { get; set; }
        public int Status { get; set; }
        public long Amount { get; set; }
        public long PostBalance { get; set; }
        public string Note { get; set; }
    }
}
