using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Point
    {
        public int X;
        public int Y;
        public char sym;

        public Point(int _x, int _y, char _sym)
        {
            X = _x;
            Y = _y;
            sym = _sym;
        }
       
        public Point(Point p)
        {
            X = p.X;
            Y = p.Y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                X = X + offset;
            }
            else if (direction == Direction.LEFT)
            {
                X = X - offset;
            }
            else if(direction == Direction.UP)
            {
                Y = Y - offset;
            }
            else if(direction == Direction.DOWN)
            {
                Y = Y + offset;
            }
        }

        public bool IsHit(Point p)
        {
            return p.X == this.X && p.Y == this.Y;
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(sym);
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public override string ToString()
        {
            return X + ", " + Y + ", " + sym;
        }

    }
}
