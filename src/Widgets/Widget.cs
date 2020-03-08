
namespace Widgets
{
    public abstract class Widget : IWidget
    {
        private Widget()
        { }

        /// <summary>
        /// New instance of widget.
        /// </summary>
        public Widget(string name, int x, int y, int size)
        {
            Name = name ?? string.Empty;
            XCoordinate = x;
            YCoordinate = y;
            Size = size;
        }


        public string Name { get; }

        public int XCoordinate { get; }
        
        public int YCoordinate { get; }
        
        public int Size { get; }


        public abstract RenderedWidget Draw();


        protected string RenderName { get => $"[{Name}]"; }

        protected string RenderCoords { get => $"(x:{XCoordinate},y:{YCoordinate})"; }

        protected string RenderSize { get => $"(size:{Size})"; }
    }
}
