using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procon_dashboard
{
    class MatchIDData
    {
        public int turn { get; set; }
        public List<Team> teams { get; set; }
        public List<List<int>> tiled { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public List<List<int>> points { get; set; }
        public List<Action> actions { get; set; }
        public long startedAtUnixTime { get; set; }
        public List<Obstacles> obstacles { get; set; }
        public List<Treasure> treasure { get; set; }
    }
}