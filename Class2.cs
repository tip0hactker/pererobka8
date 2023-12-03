using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pererobka8
{
    public class GraphFactory
    {
        public static IGraph CreateGraph(GraphType type)
        {
            switch (type)
            {
                case GraphType.Line:
                    return new LineGraph();
                case GraphType.Bar:
                    return new BarGraph();
                case GraphType.Pie:
                    return new PieChart();
                default:
                    throw new ArgumentException("Недопустимий тип графіка", "type");
            }
        }
    }
}