using System;
using OpenTK.Windowing.Desktop;

namespace VoxelEngine
{
    public class Program
    {
        public static Window Window { get; private set; }
        public static void Main()
        {
            using (Window = new Window(GameWindowSettings.Default, NativeWindowSettings.Default))
            {
                Window.Run();
            }
        }
    }
}