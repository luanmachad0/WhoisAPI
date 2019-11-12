using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class WhoisParsed
    {
     
        [Key] public int trackId { get; set; }
        public string name { get; set; }
        public object created { get; set; }
        public object changed { get; set; }
        public object expires { get; set; }
        public object dnssec { get; set; }
        public object registered { get; set; }
        public object status { get; set; }
        public IList<object> nameservers { get; set; }
        public object contacts { get; set; }
        public object throttled { get; set; }

    }

    
}