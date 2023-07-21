using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class Square : IShape
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        private int _size; 
        public int Size 
        {
            get => _size;
            set => _size = Math.Abs(value); 
        }

        public Square(int xcoordinate = 0, int ycoordinate = 0, int size = 0)
        {
            Xcoordinate = xcoordinate;
            Ycoordinate = ycoordinate;
            Size = size;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Square ({Xcoordinate},{Ycoordinate}) size = {Size}");
    }
}
