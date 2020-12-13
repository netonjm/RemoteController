using RemoteController;
using System;
using System.Windows.Forms;

namespace KeyRead
{
    public static class WinformExtensions
    {
        public static System.Windows.Forms.Keys ToWinformsKey (this RemoteController.Keys keys)
        {
            return (System.Windows.Forms.Keys)(int)keys;
        }
    }

    public abstract class Game
    {
        abstract public string ExecutableFilePath { get; }
        abstract public string ClassName { get; }
        abstract  public string WindowName { get; }
        abstract public string DisplayName { get; }
    }

    public class VPPlayerGame : Game
    {
        public override string ClassName => "VPPlayer";
        public override string WindowName => "Visual Pinball Player";
        public override string ExecutableFilePath => @"C:\Visual Pinball\VPinballX.exe";

        public override string DisplayName => "VPinball";
    }

    public class VRVPPlayerGame : Game
    {
        public override string ClassName => "SDL_app";
        public override string WindowName => "Visual Pinball Player SDL";

        public override string ExecutableFilePath => @"C:\Visual Pinball\VPinballX_GL.exe";

        public override string DisplayName => "VR-VPinball";
    }

    public class KeyService
    {
        public event EventHandler GameChanged;
        Game currentGame = null;
        public Game CurrentGame {
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
                InputManager.Keyboard.KeyUp(v.ToWinformsKey ());

            if (ev == KeyEvent.Down)
                InputManager.Keyboard.KeyDown(v.ToWinformsKey());
        }
    }
}
