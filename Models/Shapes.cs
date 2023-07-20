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

        public int Width { get; set; }
        public int Height { get; set; }

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

    public class Square : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }
        public int Size { get; set; }

        public Square(int xpoint = 0, int ypoint = 0, int size = 0)
        {
            Xpoint = xpoint;
            Ypoint = ypoint;
            Size = size;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Square ({Xpoint},{Ypoint}) size = {Size}");
    }

    public class Ellipse : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }
        public int DiameterH { get; set; }
        public int DiameterV { get; set; }

        public Ellipse(int xpoint = 0, int ypoint = 0, int diameterh = 0, int diameterv = 0)
        {
            Xpoint = xpoint;
            Ypoint = ypoint;
            DiameterH = diameterh;
            DiameterV = diameterv;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Ellipse ({Xpoint},{Ypoint}) diameterH = {DiameterH} diameterV = {DiameterV}");
    }

    public class Circle : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }
        public int Size { get; set; }

        public Circle(int xpoint = 0, int ypoint = 0, int size = 0)
        {
            Xpoint = xpoint;
            Ypoint = ypoint;
            Size = size;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Circle ({Xpoint},{Ypoint}) size = {Size}");

    }

    public class TextBox : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Text { get; set; }

        public TextBox(int xpoint = 0, int ypoint = 0, int height = 0, int width = 0, string text = "sample text")
        {
            Xpoint = xpoint;
            Ypoint = ypoint;
            Height = height;
            Width = width;
            Text = text;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Textbox ({Xpoint},{Ypoint}) width = {Width} height = {Height} Text = \"{Text}\"");
    }
}
