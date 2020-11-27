using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    class Obstacles
    {
        public int x { get; set; }
        public int y { get; set; }
        public Obstacles(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
