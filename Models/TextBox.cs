using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class TextBox : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }

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

        public TextBox(int xpoint = 0, int ypoint = 0, int width = 0, int height = 0, string text = "sample text")
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
