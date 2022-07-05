using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Drawing;
namespace TestKernel
{
    public class Kernel : Sys.Kernel
    {
        Canvas canvas;
        
        protected override void BeforeRun()
        {
            Graphics.Mouse.DrawMouse(canvas, 800, 600);
        }

        protected override void Run()
        {
            Graphics.Mouse.UpdateMouse(canvas, Color.Black, new Pen(Color.White));
            Graphics.Framework.DrawWindow(canvas, 0, 0, 200, 200, new Pen(Color.White));
        }
    }
}
