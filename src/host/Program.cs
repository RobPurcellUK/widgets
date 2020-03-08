using System;
using draw=System.Drawing;
using Widgets;

namespace host
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start test host");

            Canvas canvas = new Canvas();

            // Empty canvas
            canvas.RenderCanvas();

            // Fill it up ...
            canvas.AddWidget(new Square(null, 0, 0, 0));
            canvas.AddWidget(new Square("square1", 10, 20, 30));
            canvas.AddWidget(new Square("square2", -10, int.MaxValue, 0));
            canvas.AddWidget(new Square("square3", int.MinValue, 50, 3));
            canvas.AddWidget(new Rectangle("rect1", 20, 80, 2, 12, 7));
            canvas.AddWidget(new Rectangle("rect2", 20, 80, 2, int.MinValue, 7));
            canvas.AddWidget(new Rectangle("rect3", 20, 80, 2, 12, int.MaxValue));
            canvas.AddWidget(new Circle("circle1", 30, 60, 5));
            canvas.AddWidget(new Ellipse("ellipse1", 40, 50, 10, 50, 22));
            canvas.AddWidget(new Ellipse("ellipse2", 40, 50, 10, -50, 22));
            canvas.AddWidget(new Ellipse("ellipse3", 40, 50, 10, 50, -1));
            canvas.AddWidget(
                new TextBox("text1", 100, 10, 18, 100, 200, draw.Color.White) { Text = "hello" }
                );
            canvas.AddWidget(
                new TextBox("text1", 100, 10, 18, 100, 200, draw.Color.Aqua) { Text = "with text" }
                );
            canvas.AddWidget(
                new TextBox("text1", 100, 10, 18, 100, 200, draw.Color.Aqua) { Text = null}
                );
            canvas.AddWidget(new TextBox("text1", 100, 10, 18, 100, 200, draw.Color.Aqua));

            canvas.RenderCanvas();

            Console.WriteLine("Done test host");
            Console.ReadLine();
        }
    }
}
