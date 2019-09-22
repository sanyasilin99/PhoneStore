using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestWebApplication.Models
{
    public class Phone
    {
        public int PhoneId { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }
        
        public int Price { get; set; }
    }
}