using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    class Team
    {
        public List<Agent> agents { get; set; }
        public int teamID { get; set; }
        public int areaPoint { get; set; }
        public int tilePoint { get; set; }
    }
}
