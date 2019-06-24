using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGLab4
{
    class Edge
    {
        
        public int yMin;
        public int yMax;

        public float xMin;

        public float w; // dx/dy

        public Edge next;

        public Edge(int yMax, int yMin, float xMin, float w, Edge next)
        {
            this.yMax = yMax;
            this.yMin = yMin;
            this.xMin = xMin;
            this.w = w;
            this.next = next;
        }
    }
}
