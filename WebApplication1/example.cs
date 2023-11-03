using System.Drawing;

namespace _01.Models
{
    public partial class example
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Point point1 = new Point { X = 1, Y = 1 };
            Point point2 = new Point { X = 2, Y = 2 };
            Point point3 = new Point { X=3, Y=3 };

            bool areinline = Numccal.ArePointInLine(point1, point2, point3);

            if (areinline)
            {
                Console.Write("Yes Points Are in Oneline");
            }
            else
            {
                Console.Write("NO The Point Are not in Oneline");
            }
        }
    }
}
