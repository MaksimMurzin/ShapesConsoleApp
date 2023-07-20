using ShapesConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesConsoleApp.Helpers
{
    public static class ShapeHelpers
    {
        public static void Print(params IShape[] shapes)
        {
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine("Requested Drawing");
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("");

            foreach (var shape in shapes)
            {
                Console.WriteLine(shape.PrintProperties());
            }
            Console.WriteLine("");
            Console.WriteLine("--------------------------------------------------------------------");
        }

        public static string BuildString(string message)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(message);
            return sb.ToString();
        }
    }
}
