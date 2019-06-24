using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLab4
{
    class EdgeCompare : IComparer<Edge>
    {
        public int Compare(Edge e1, Edge e2)
        {
            float delta = e1.xMin - e2.xMin;
            float dif = 0;
            if (delta > dif)        // e1.xMin > e2.xMin
                return 1;
            else if (delta < dif)   // e1.xMin < e2.xMin
                return -1;
            else
                return 0;
        }
    }
}
