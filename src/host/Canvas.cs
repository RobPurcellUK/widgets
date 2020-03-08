using System;
using System.Collections.Generic;
using Widgets;

namespace host
{
    /// <summary>
    /// Canvas for displaying IWidgets.
    /// No size limit on canvas, widgets can render anywhere.
    /// No way to clear the canvas.
    /// </summary>
    public class Canvas
    {
        private readonly IList<IWidget> _widgets = new List<IWidget>();

        /// <summary>
        /// Add a widget to this canvas.
        /// </summary>
        public void AddWidget(IWidget widget)
        {
            _widgets.Add(widget);
        }

        /// <summary>
        /// Render this canvas and it's widgets.
        /// </summary>
        public void RenderCanvas()
        {
            LogRendering();

            foreach (var w in _widgets)
            {
                var rendered = w.Draw();
                
                // ... Display this rendered widget here ...

                // Also log rendered widget
                LogRenderedWidget(rendered);
            }

            LogRenderingEnd();
        }

        // ---- Logging could be via something nicer like Serilog ----

        private void LogRenderingEnd()
        {
            Console.WriteLine();
        }

        private void LogRendering()
        {
            Log($"Rendering canvas with {_widgets.Count} widgets", ConsoleColor.Yellow);
        }

        /// <summary>
        /// Log a rendered widget.
        /// </summary>
        private void LogRenderedWidget(RenderedWidget widget)
        {
            Log("- " + widget.RenderedText, ConsoleColor.Cyan);
        }

        private void Log(string msg, ConsoleColor colour)
        {
            var bakColour = Console.ForegroundColor;
            Console.ForegroundColor = colour;
            Console.WriteLine(msg);
            Console.ForegroundColor = bakColour;
        }
    }
}
