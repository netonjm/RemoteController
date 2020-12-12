using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace KeyRead
{
    public class NativeKeyboardHelper
    {
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(IntPtr point);

        const int LeftPinball = 0x08;
        const int WM_KEYDOWN = 0x100;
        const int WM_KEYUP = 0x101;
        const UInt32 WM_Char = 0x0102;
        const int VK_F5 = 0x74;
        const int VK_28 = 0x28;

        [DllImport("user32.dll")]
        public static extern bool PostMessage(IntPtr hWnd, UInt32 Msg, int wParam, int lParam);
        [DllImport("user32.dll", SetLastError = true)]

        public static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]

        public static extern IntPtr FindWindowEx(IntPtr hwndParent, IntPtr hwndChildAfter, string lpszClass, string lpszWindow);
    }
}
