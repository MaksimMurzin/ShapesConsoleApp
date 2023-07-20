
namespace ShapesConsoleApp.Models
{
    /// <summary>
    /// I am assuming that points are given as integers and not doubles
    /// </summary>
    public interface IShape
    {
        public int Xpoint { get; set; }
        public int Ypoint { get; set; }

        public string PrintProperties();
    }
}
