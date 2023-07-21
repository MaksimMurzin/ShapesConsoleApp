using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class Circle : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }

        private int _size;
        public int Size 
        {
            get => _size;
            set => _size = Math.Abs(value);
        }

        public Circle(int xpoint = 0, int ypoint = 0, int size = 0)
        {
            Xpoint = xpoint;
            Ypoint = ypoint;
            Size = size;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Circle ({Xpoint},{Ypoint}) size = {Size}");
    }
}
