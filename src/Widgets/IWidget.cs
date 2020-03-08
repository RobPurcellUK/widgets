
namespace Widgets
{
    // RP - How is Name uniqueness defined? How is it enforced?
    // RP - X and Y both say 'horizontally' in the brief. Assumed Y is vertical, to check.
    // RP - What does 'Size' represent?
    // RP - Could use a Point for the co-ords, but then depending on Sys.Drawing.

    public interface IWidget
    {
        /// <summary>
        /// Unique name for this widget.
        /// </summary>
        string Name { get; }

        /// <summary>
        /// Horizontally positioning the widget.
        /// </summary>
        int XCoordinate { get; }

        /// <summary>
        /// Vertically positioning the widget.
        /// </summary>
        int YCoordinate { get; }

        /// <summary>
        /// Simple size of the widget.
        /// </summary>
        int Size { get; }

        /// <summary>
        /// Render this Widget for display.
        /// </summary>
        RenderedWidget Draw();
    }
}
