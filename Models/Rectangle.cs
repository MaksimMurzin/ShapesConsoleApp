using ShapesConsoleApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapesConsoleApp.Models
{
    public class Rectangle : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }

        private int _height, _width;
        public int Height
        {
            get => _height;
            set => _height = Math.Abs(value);
        }

        public int Width
        {
            get => _width;
            set => _width = Math.Abs(value);
        }

        public Rectangle(int xpoint = 0, int ypoint = 0, int width = 0, int height = 0)
        {
            Xpoint = xpoint;
            Ypoint = ypoint;
            Width = width;
            Height = height;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Rectangle ({Xpoint},{Ypoint}) width = {Width}, height = {Height}");
    }
}
