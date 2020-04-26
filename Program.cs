using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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
            int i = 0;
            while(i < 5)
            {
                Turtle.Move(10);
                Turtle.TurnRight();
                Turtle.Move(10);
                Turtle.TurnRight();

                Turtle.Move(10);
                Turtle.TurnLeft();
                Turtle.Move(10);
                Turtle.TurnLeft();

                i++;
            }
        }
    }
}
