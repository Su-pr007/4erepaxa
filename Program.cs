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
            while(i < 2)
            {
                Turtle.Move(80);
                Turtle.Angle += 45;
                Turtle.Move(30);
                Turtle.Angle += 90;
                Turtle.Move(30);
                Turtle.Angle += 45;

                i++;
            }
        }
    }
}
