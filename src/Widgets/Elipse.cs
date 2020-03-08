
namespace Widgets
{
    public class Ellipse : Widget
    {
        private const string WIDGET_TYPE = "Elipse";


        public int HorizontalDiameter { get; }

        public int VerticalDiameter { get; }


        public Ellipse(string name, int x, int y, int size,
            int horizontalDiameter, int verticalDiameter
            )
            : base(name, x, y, size)
        {
            HorizontalDiameter = horizontalDiameter;
            VerticalDiameter = verticalDiameter;
        }


        public override RenderedWidget Draw()
        {
            return new RenderedWidget(
                $"{WIDGET_TYPE} {RenderName} {RenderCoords} {RenderSize} {RenderHV}"
                );
        }


        protected string RenderHV { 
            get => $"(Diameters | horiz:{HorizontalDiameter}, vert:{VerticalDiameter})"; 
        }
    }
}
