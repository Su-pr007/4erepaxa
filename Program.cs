using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;

namespace NewTurtle
{
    class Program
    {
        static void Main(string[] args)
        {
            Turtle.Speed = 9;
            WriteM(50, 200, 100);
            WriteA(200, 200, 100);
            WriteM(350, 200, 100);
            WriteA(500, 200, 100);
        }
        static void WriteM(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 150;
            int line1 = Microsoft.SmallBasic.Library.Math.SquareRoot(System.Math.Pow(size, 2)+ System.Math.Pow(size/2, 2));
            Turtle.Move(line1);
            Turtle.Angle = 30;
            Turtle.Move(line1);
            Turtle.Angle = 180;
            Turtle.Move(size);
        }
        static void WriteA(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 30;
            int line1 = Microsoft.SmallBasic.Library.Math.SquareRoot(System.Math.Pow(size, 2) + System.Math.Pow(size / 2, 2));
            Turtle.Move(line1);
            Turtle.Angle = 150;
            Turtle.Move(line1);
            Turtle.PenUp();
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 30;
            Turtle.Move(line1 / 2);
            Turtle.Angle = 90;
            Turtle.PenDown();
            int line2 = Microsoft.SmallBasic.Library.Math.SquareRoot(System.Math.Pow(line1 / 2, 2) - System.Math.Pow(size / 2, 2));
            Turtle.Move(size - line2*2);
        }
    }
}
