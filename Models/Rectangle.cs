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
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

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

        public Rectangle(int xcoordinate = 0, int ycoordinate = 0, int width = 0, int height = 0)
        {
            Xcoordinate = xcoordinate;
            Ycoordinate = ycoordinate;
            Width = width;
            Height = height;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Rectangle ({Xcoordinate},{Ycoordinate}) width = {Width}, height = {Height}");
    }
}
