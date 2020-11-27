using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    class Agent
    {
        public int x { get; set; }
        public int y { get; set; }
        public int agentID { get; set; }

        public Agent(int x, int y, int agentID)
        {
            this.x = x;
            this.y = y;
            this.agentID = agentID;
        }
        
    }
}
