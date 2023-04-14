using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api
{
    public class pricemodel
    {
        
        public double last { get; set; }
        public double sell { get; set; }
        public double buy { get; set; }
        public double high { get; set; }
        public double low { get; set; }
        public double averagePrice { get; set; }
        public string symbol { get; set; }
        
    }
}
