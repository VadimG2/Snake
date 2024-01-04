using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class VerticalLine
    {
        List<Point> pList;
        public VerticalLine(int x, int yLower, int yUpper, char sym)
        {
            pList = new List<Point>();
            for (int y = yLower; y <= yUpper; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}