using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    public class Matche
    {
        public int id { get; set; }
        public int intervalMillis { get; set; }
        public string matchTo { get; set; }
        public int teamID { get; set; }
        public int turnMillis { get; set; }
        public int turns { get; set; }
    }
    
   
}
