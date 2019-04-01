using System;
using System.Runtime.InteropServices;

namespace UnfuckMicrophone
{
    public static class HandleYolo
    {
        [DllImport("kernel32.dll")]
        public extern static IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        public extern static bool ShowWindow(IntPtr hWnd, int nCmdShow);

        public const int SW_HIDE = 0;
        public const int SW_SHOW = 5;
    }
}
