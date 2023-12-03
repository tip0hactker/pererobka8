using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pererobka8
{
    static void Main(string[] args)
    {
        // Введення типу графіка та даних для візуалізації

        Console.WriteLine("Введіть тип графіка:");
        GraphType type = (GraphType)Enum.Parse(typeof(GraphType), Console.ReadLine());

        Console.WriteLine("Введіть дані для візуалізації:");
        string[] data = Console.ReadLine().Split(',');

        // Створення графіка

        IGraph graph = GraphFactory.CreateGraph(type);

        // Візуалізація графіка

        graph.Draw();
    }
}