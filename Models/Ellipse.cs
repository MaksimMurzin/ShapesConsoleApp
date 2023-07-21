using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class Ellipse : IShape
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }
        private int _diameterH, _diameterV;

        public int DiameterH 
        {
            get => _diameterH;
            set => _diameterH = Math.Abs(value);
        }

        public int DiameterV 
        {
            get => _diameterV;
            set => _diameterV = Math.Abs(value);
        }

        public Ellipse(int xcoordinate = 0, int ycoordinate = 0, int diameterh = 0, int diameterv = 0)
        {
            Xcoordinate = xcoordinate;
            Ycoordinate = ycoordinate;
            DiameterH = diameterh;
            DiameterV = diameterv;
        }

        public string PrintProperties()
            => ShapeHelpers.BuildString($"Ellipse ({Xcoordinate},{Ycoordinate}) diameterH = {DiameterH} diameterV = {DiameterV}");
    }
}
