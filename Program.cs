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
            WriteT(200, 200, 100);
            WriteO(250, 200, 100);
            WriteR(350, 200, 100);
            WriteT(430, 200, 100);
        }
        static void WriteT(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.Angle = 270;
            Turtle.Move(size / 4);
            Turtle.Angle = 90;
            Turtle.Move(size / 2);
        }
        static void WriteO(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnRight();
            Turtle.Move(size / 2);
            Turtle.TurnRight();
            Turtle.Move(size);
            Turtle.TurnRight();
            Turtle.Move(size / 2);
        }
        static void WriteR(int x, int y, int size)
        {
            Turtle.X = x;
            Turtle.Y = y;
            Turtle.Angle = 0;
            Turtle.Move(size);
            Turtle.TurnRight();
            Turtle.Move(size / 3);
            Turtle.TurnRight();
            Turtle.Move(size / 3);
            Turtle.TurnRight();
            Turtle.Move(size / 3);
        }
    }
}
