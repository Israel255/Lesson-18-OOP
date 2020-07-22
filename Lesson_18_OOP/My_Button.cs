using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18_OOP
{
    internal class My_Button
    {
        protected Point _top_left;
        protected Point _bottom_right;
        private int _width;
        private int _height;

        internal My_Button(Point top_left, Point bottom_right)
        {
            _top_left = top_left;
            _bottom_right = bottom_right;
            if (Set_Top_Left(top_left) != true || Set_Bottom_Right(bottom_right) != true)
            {
                Console.WriteLine("The bottom right needs to right and bottom!! and top ledt needs to be top and left!!!");
                _top_left = null;
                _bottom_right = null;
            }
        }
        internal int Get_Width()
        {
            _width = _bottom_right.Get_X();
            return _width;
        }
        internal int Get_Height()
        {
            _height = _top_left.Get_Y();
            return _height;
        }
        internal bool Set_Top_Left(Point top_left)
        {
            if (top_left.Get_X() <= _bottom_right.Get_X() && top_left.Get_Y() >= _bottom_right.Get_Y())
            {
                _top_left = top_left;
                _height = top_left.Get_Y();
                _width = top_left.Get_X();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal bool Set_Bottom_Right(Point bottom_right)
        {
            if (bottom_right.Get_X() >= _top_left.Get_X() && bottom_right.Get_Y() <= _top_left.Get_Y())
            {
                _bottom_right = bottom_right;
                _height = bottom_right.Get_Y();
                _width = bottom_right.Get_X();
                return true;
            }
            else
            {
                return false;
            }
        }
        internal Point Get_Top_Left()
        {
            return _top_left;
        }
        internal Point Get_Bottom_Right()
        {
            return _bottom_right;
        }

        public override string ToString()
        {
            return "Top Left Height (Y): " + _top_left.Get_Y() + " Top Left Width (x): " + _top_left.Get_X() + " Bottom Right Height (Y): " + _bottom_right.Get_Y() + " Bottom Right Width (X): " + _bottom_right.Get_X();
        }
    }
}
