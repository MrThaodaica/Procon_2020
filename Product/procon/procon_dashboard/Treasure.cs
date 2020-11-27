using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    class Treasure
    {
        public int status { get; set; }
        public int point { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public Treasure(int status, int point, int x, int y)
        {
            this.status = status;
            this.point = point;
            this.x = x;
            this.y = y;
        }
    }
}
