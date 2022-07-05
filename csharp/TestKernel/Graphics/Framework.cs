using Cosmos.System;
using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mouse = Cosmos.System.MouseManager;
using MouseState = Cosmos.System.MouseState;


namespace TestKernel.Graphics
{
    public class Framework
    {
        public static void DrawLabel(Canvas canvas,int x, int y, Pen color,string s)
        {
            ASC16.DrawACSIIString(canvas, color, s, x, y);
        }
        public static void DrawButton(Canvas canvas, int x, int y, int width, int height, Pen buttoncolor, Pen labelcolor,string s)
        {
            canvas.DrawFilledRectangle(buttoncolor, x, y, width, height);
            ASC16.DrawACSIIString(canvas, labelcolor, s, x, y);
        }
        public static void DrawWindow(Canvas canvas, int x, int y, int width, int height, Pen color)
        {
            canvas.DrawFilledRectangle(color, x, y, width, height);
            canvas.DrawFilledRectangle(new Pen(Color.Red),width- 16,height -16,16,16);
            ASC16.DrawACSIIString(canvas, new Pen(Color.White),"x",width-10, height-10);
            if (Cosmos.System.MouseManager.MouseState == MouseState.Left && Cosmos.System.MouseManager.X ==width)
            {
                canvas.Clear();
            }

        }
    }
}
