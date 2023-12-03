using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pererobka8
{
    public abstract class Graph
    {
        public abstract void Draw();
    }

    public class LineGraph : Graph
    {
        public override void Draw()
        {
            // ...
        }
    }

    public class BarGraph : Graph
    {
        public override void Draw()
        {
            // ...
        }

        public class PieChart : Graph
        {
            public override void Draw()
            {
                // ...
            }
        }
    }
}