
namespace ShapesConsoleApp.Models
{
    public interface IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }

        public string PrintProperties();
    }
}
