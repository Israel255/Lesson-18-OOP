using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18_OOP
{
    internal class Point
    {
        private int _x;
        private int _y;

        internal Point(int x, int y)
        {
            Set_X(x);
            Set_Y(y);
        }
        internal int Get_X()
        {
            return _x;
        }
        internal int Get_Y()
        {
            return _y;
        }
        internal void Set_X(int x)
        {
            if (x >= 0 && x <= My_Canvas._MAX_WIDTH && x <= My_Canvas._MAX_HEIGHT)
            {
                _x = x;
            }
            else
            {
                Console.WriteLine("The x need to be bigger than 0 and smaller than " + My_Canvas._MAX_HEIGHT + " and " + My_Canvas._MAX_WIDTH);
            }
        }
        internal void Set_Y(int y)
        {
            if (y >= 0 && y <= My_Canvas._MAX_WIDTH && y <= My_Canvas._MAX_HEIGHT)
            {
                _y = y;
            }
            else
            {
                Console.WriteLine("The y need to be bigger than 0 and smaller than " + My_Canvas._MAX_HEIGHT + " and " + My_Canvas._MAX_WIDTH);
            }
        }

        public override string ToString()
        {
            return "X: " + Get_X() + "Y: " + Get_Y();
        }
    }
}
