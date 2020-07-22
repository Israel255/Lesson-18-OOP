using Lesson_18_OOP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class My_Class
    {
        static void Main(string[] args)
        {
            My_Canvas.Create_New_Button(3, 30, 5, 10);
            My_Canvas.Create_New_Button(2, 3, 2, 1);
            My_Canvas.Create_New_Button(200, 300, 200, 100);
            My_Canvas.Move_Button(3, 30, 40);
            My_Canvas.Delete_Last_Button();
            My_Canvas.Clear_All_Buttons();
            Console.WriteLine(My_Canvas.Get_Current_Number_Of_Buttons());
            Console.WriteLine(My_Canvas.Get_Max_Number_Of_Buttons());
            Console.WriteLine(My_Canvas.Get_The_Max_Width_Of_A_Button());
            Console.WriteLine(My_Canvas.Get_The_Max_Height_Of_A_Button());
            Console.WriteLine(My_Canvas.Is_Point_Inside_A_Button(230, 340));
            Console.WriteLine(My_Canvas.Check_If_Any_Button_Is_Overlapping());
            My_Canvas.Print();
        }
    }
}
