using ShapesConsoleApp.Helpers;

namespace ShapesConsoleApp.Models
{
    public class Ellipse : IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }
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
}
