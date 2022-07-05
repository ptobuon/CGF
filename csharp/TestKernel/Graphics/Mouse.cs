using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sys = Cosmos.System;

namespace TestKernel.Graphics
{
    public class Mouse
    {
        public static void DrawMouse(Canvas canvas, int x, int y)
        {
            canvas = new SVGAIICanvas(new Mode(x, y, ColorDepth.ColorDepth32));
            canvas.Clear(Color.Green);
            Sys.MouseManager.ScreenWidth = 800;
            Sys.MouseManager.ScreenHeight = 600;
            Sys.MouseManager.X = (uint)((int)canvas.Mode.Columns / 2);
            Sys.MouseManager.Y = (uint)((int)canvas.Mode.Rows / 2);
        }
        public static void UpdateMouse(Canvas canvas, Color canvascolor, Pen cursorcolor)
        {
            try
            {
                canvas.DrawLine(cursorcolor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X + 6, (int)Cosmos.System.MouseManager.Y);
                canvas.DrawLine(cursorcolor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y + 6);
                canvas.DrawLine(cursorcolor, (int)Cosmos.System.MouseManager.X, (int)Cosmos.System.MouseManager.Y,
                    (int)Cosmos.System.MouseManager.X + 12, (int)Cosmos.System.MouseManager.Y + 12);
                canvas.Display();
                canvas.Clear(canvascolor);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
