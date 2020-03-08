
namespace Widgets
{
    /// <summary>
    /// Rendered IWidget. Implementation of rendering
    /// can change internally.
    /// </summary>
    public class RenderedWidget
    {
        /// <summary>
        /// Loggable text version of rendered IWidget.
        /// </summary>
        public string RenderedText { get; private set; }

        private RenderedWidget()
        { }

        public RenderedWidget(string renderedText)
        {
            RenderedText = renderedText;
        }
    }
}