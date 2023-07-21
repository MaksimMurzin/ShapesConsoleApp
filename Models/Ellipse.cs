using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class Ellipse : IShape
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }
        private int _diameterh, _diameterw;

        public int DiameterH 
        {
            get => _diameterh;
            set => _diameterh = Math.Abs(value);
        }

        public int DiameterV 
        {
            get => _diameterw;
            set => _diameterw = Math.Abs(value);
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
