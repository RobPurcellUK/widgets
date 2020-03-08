
namespace Widgets
{
    public class Square : Widget
    {
        private const string WIDGET_TYPE = "Square";

        public Square(string name, int x, int y, int size)
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
