
namespace ShapesConsoleApp.Models
{
    public interface IShape
    {
        public int Xcoordinate { get; set; }
        public int Ycoordinate { get; set; }

        public string PrintProperties();
    }
}
