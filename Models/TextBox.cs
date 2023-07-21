using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class TextBox : IShape
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        private int _height,_width;
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

        public string Text { get; set; }

        public TextBox(int xcoordinate = 0, int ycoordinate = 0, int width = 0, int height = 0, string text = "sample text")
        {
            Xcoordinate = xcoordinate;
            Ycoordinate = ycoordinate;
            Height = height;
            Width = width;
            Text = text;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Textbox ({Xcoordinate},{Ycoordinate}) width = {Width} height = {Height} Text = \"{Text}\"");
    }
}
