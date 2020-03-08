
namespace Widgets
{
    public class Circle : Widget
    {
        private const string WIDGET_TYPE = "Circle";

        public Circle(string name, int x, int y, int size)
            : base(name, x, y, size)
        {
        }

        public override RenderedWidget Draw()
        {
            return new RenderedWidget(
                $"{WIDGET_TYPE} {RenderName} {RenderCoords} {RenderSize}"
                );
        }
    }
}
