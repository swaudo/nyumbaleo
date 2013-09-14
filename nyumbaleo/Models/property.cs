using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;

namespace nyumbaleo.Models
{
    public class property
    {
        public int id { get; set; }
        [DisplayName("Location")]
        public string location { get; set; }
        [DisplayName("Property type")]
        public string type { get; set; }
        [DisplayName("No of Rooms")]
        public string rooms { get; set; }
        [DisplayName("Status")]
        public string status { get; set; }
        [DisplayName("Add description")]
        public string description { get; set; }
        [DisplayName("Rent or Sale")]
        public string rent_or_buy { get; set; }
        [DisplayName("Price")]
        public int cost { get; set; }

        public string image { get; set; }
    }
}