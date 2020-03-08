
namespace Widgets
{
    internal static class ColorExtensions
    {
        public static string AsArgbString(this System.Drawing.Color color)
        {
            return $"{color.A}.{color.R}.{color.G}.{color.B}";
        }
    }
}
