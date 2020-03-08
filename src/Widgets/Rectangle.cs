
namespace Widgets
{
    public class Rectangle : Widget
    {
        private const string WIDGET_TYPE = "Rectangle";


        public int Height { get; }

        public int Width { get; }


        public Rectangle(string name, int x, int y, int size, int height, int width)
            : base(name, x, y, size)
        {
            Height = height;
            Width = width;
        }


        public override RenderedWidget Draw()
        {
            return new RenderedWidget(
                $"{WIDGET_TYPE} {RenderName} {RenderCoords} {RenderSize} {RenderHW}"
                );
        }


        protected string RenderHW { get => $"(height:{Height}, width:{Width})"; }
    }
}
