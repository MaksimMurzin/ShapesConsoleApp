using ShapesConsoleApp.Helpers;
using ShapesConsoleApp.Models;

var rectangle = new Rectangle(10,10,40,30);
var square = new Square(15,30,35);
var ellipse = new Ellipse(100,150,300,200);
var circle = new Circle(1, 1, 300);
var textbox = new TextBox(5, 5, 100, 200);

ShapeHelpers.Print(rectangle,square, ellipse, circle, textbox);
