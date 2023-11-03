using System.Drawing;

namespace _01.Models
{
    public class Numccal:example
    {
        public static bool ArePointInLine(Point point1, Point point2,Point point3)
        {
            int slope = (point2.Y - point1.Y) / (point2.X - point1.X);
            return slope == (point3.Y - point1.Y) / (point3.X - point1.X);
        }
    }
}
