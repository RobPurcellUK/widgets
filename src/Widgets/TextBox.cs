using System.Drawing;

namespace Widgets
{
    public class TextBox : Rectangle
    {
        private const string WIDGET_TYPE = "TextBox";

        private static readonly Color EMPTY_TEXT_BG = Color.Red;


        public Color BackgroundColour { get; }


        /// <summary>
        /// Text to display in the TextBox.
        /// </summary>
        public string Text
        {
            get { return _text; }
            set { _text = value ?? string.Empty; }
        }

        private string _text = string.Empty;


        public TextBox(string name, int x, int y, int size, int height, int width,
            Color bgColour
            )
            : base(name, x, y, size, height, width)
        {
            BackgroundColour = bgColour;
        }


        public override RenderedWidget Draw() => 
            new RenderedWidget(
                $"{WIDGET_TYPE} {RenderName} {RenderCoords} {RenderSize} {RenderHW} {RenderBG} {Text}"
                );


        protected string RenderBG { 
            get {
                var bgc = Text == string.Empty ? Color.Red : BackgroundColour;
                var bg = bgc.IsNamedColor ? bgc.Name : bgc.AsArgbString();
                return $"(background:{bg})"; 
            }
        }
    }
}
