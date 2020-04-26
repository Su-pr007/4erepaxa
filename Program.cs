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
            while (true)
            {
                GraphicsWindow.KeyDown += GraphicsWindow_KeyDown;
                Turtle.Move(10);
            }
        }

        private static void GraphicsWindow_KeyDown()
        {
            string key = GraphicsWindow.LastKey;
            switch (key)
            {
                case "Up":
                    Turtle.Angle = 0;
                    break;
                case "Right":
                    Turtle.Angle = 90;
                    break;
                case "Down":
                    Turtle.Angle = 180;
                    break;
                case "Left":
                    Turtle.Angle = 270;
                    break;
                case "Escape":
                    Process.GetCurrentProcess().Kill();
                    break;
            }
        }
    }
}
