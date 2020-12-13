using RemoteController;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

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

    public class WinFormsGameService : IGameService
    {
        public event EventHandler GameChanged;

        Game currentGame = null;
        public Game CurrentGame
        {
            get => currentGame;
            set
            {
                if (currentGame == value)
                    return;
                currentGame = value;
                GameChanged?.Invoke(this, EventArgs.Empty);
            }
        }
        IntPtr GetWindowIntPtr() => NativeKeyboardHelper.FindWindow("VPPlayer", "Visual Pinball Player");

        public void SendKey(KeyEvent ev, RemoteController.Keys v)
        {
            //msg = {msg=0x100 (WM_KEYDOWN) hwnd=0x380fb2 wparam=0x28 lparam=0x1500001 result=0x0}

            NativeKeyboardHelper.SetForegroundWindow(GetWindowIntPtr());
            ////VPinballX
            //IntPtr editx = FindWindowEx(notepad, IntPtr.Zero, "VPPlayer", null);
            ////Visual Pinball Player
            ////PostMessage(p.MainWindowHandle, WM_Char, LeftPinball, 31);
            //PostMessage(notepad, WM_KEYDOWN, (int)Keys.D5, 0);

            if (ev == KeyEvent.Up)
                InputManager.Keyboard.KeyUp(v.ToWinformsKey());

            if (ev == KeyEvent.Down)
                InputManager.Keyboard.KeyDown(v.ToWinformsKey());
        }

        public void SetCurrentGame(int gameNumber)
        {
            if (gameNumber == 0)
            {
                if (!(CurrentGame is VPPlayerGame))
                {
                    CurrentGame = new VPPlayerGame();

                }
            }
            else if (gameNumber == 1)
            {
                if (!(CurrentGame is VPPlayerGame))
                {
                    CurrentGame = new VPPlayerGame();
                }
            }
            else
            {

            }
        }
    }
}
