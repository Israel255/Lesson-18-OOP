using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_18_OOP
{
    public class My_Canvas
    {
        public const int _MAX_WIDTH = 800;
        public const int _MAX_HEIGHT = 600;
        private static int _button_index = 0;
        private static int _max_buttons = 3;
        private static My_Button[] _button = new My_Button[_max_buttons];

        public static int Get_Current_Number_Of_Buttons()
        {
            return _button_index;
        }
        public static int Get_Max_Number_Of_Buttons()
        {
            return _max_buttons;
        }
        public static int Get_The_Max_Width_Of_A_Button()
        {
            int biggest_width = 0;
            if (_button_index > 0)
            {
                for (int i = 0; i < _button.Length; i++)
                {
                    if (_button[i].Get_Width() >= biggest_width)
                    {
                        biggest_width = _button[i].Get_Width();
                    }
                }
                return biggest_width;
            }
            else
            {
                return biggest_width;
            }
        }
        public static int Get_The_Max_Height_Of_A_Button()
        {
            int biggest_height = 0;
            if (_button_index > 0)
            {
                for (int i = 0; i < _button.Length; i++)
                {
                    if (_button[i].Get_Height() >= biggest_height)
                    {
                        biggest_height = _button[i].Get_Height();
                    }
                }
                return biggest_height;
            }
            else
            {
                return biggest_height;
            }
        }
        public static bool Create_New_Button(int x1,int y1,int x2,int y2)
        {
            bool answer = true;
            Point top_left;
            Point bottom_right;
            for (int i = 0; i < _button.Length; i++)
            {
                if (_button[i] == null)
                {
                    top_left = new Point(x1, y1);
                    bottom_right = new Point(x2, y2);
                    _button[i] = new My_Button(top_left, bottom_right);
                    _button_index++;
                    answer = true;
                    break;
                }
            }
            if (_button_index == _max_buttons)
            {
                answer = false;
            }
            return answer;
        }
        public static bool Move_Button(int button_number, int x, int y)
        {
            if (button_number >= 0 && button_number <= _max_buttons)
            {
                int top_left_x = _button[button_number - 1].Get_Top_Left().Get_X();
                int top_left_y = _button[button_number - 1].Get_Top_Left().Get_Y();
                int bottom_right_x = _button[button_number - 1].Get_Bottom_Right().Get_X();
                int bottom_right_y = _button[button_number - 1].Get_Bottom_Right().Get_Y();
                top_left_x += x;
                top_left_y += y;
                bottom_right_x += x;
                bottom_right_y += y;
                _button[button_number - 1] = new My_Button(new Point(top_left_x, top_left_y), new Point(bottom_right_x, bottom_right_y));
                return true;
            }
            else
            {
                Console.WriteLine("button number not good");
                return false;
            }
        }
        public static bool Delete_Last_Button()
        {
            if (_button_index > 0)
            {
                _button[_button_index - 1] = null;
                _button_index--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public static void Clear_All_Buttons()
        {
            for (int i = 0; i < _button.Length; i++)
            {
                Delete_Last_Button();
            }
        }
        public static bool Is_Point_Inside_A_Button(int x, int y)
        {
            bool equal = false;
            for (int i = 0; i < _button.Length; i++)
            {
                if (_button_index == 0)
                {
                    equal = false;
                    break;
                }
                if (x == _button[i].Get_Width() && y == _button[i].Get_Height())
                {
                    equal = true;
                    break;
                }
                else
                {
                    equal = false;
                }
            }
            return equal;
        }
        public static bool Check_If_Any_Button_Is_Overlapping()
        {
            int shetah = 0;
            bool the_same = false;
            for (int i = 0; i < _button.Length; i++)
            {
                if (_button_index == 0)
                {
                    the_same = false;
                    break;
                }
                shetah = _button[i].Get_Height() * _button[i].Get_Width();
                for (i += 1; i < _button.Length; i++)
                {
                    if (shetah == (_button[i].Get_Height() * _button[i].Get_Width()))
                    {
                        the_same = true;
                        break;
                    }
                    else
                    {
                        the_same = false;
                    }
                }
                if (the_same == true)
                {
                    break;
                }
            }
            return the_same;
        }
        public static void Print()
        {
            for (int i = 0; i < _button.Length; i++)
            {
                if (_button_index > 0)
                {
                    Console.WriteLine("Number " + (i + 1) + " x: " + _button[i].Get_Width());
                    Console.WriteLine("Number " + (i + 1) + " y: " + _button[i].Get_Height());
                    _button_index--;
                }
            }
        }

        public override string ToString()
        {
            return "Number of buttons in the array: " + _button_index;
        }
    }
}
