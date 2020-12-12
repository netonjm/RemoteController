using System.Windows.Forms;
using WebSocketSharp;

namespace RemoteController.Client
{
    public enum KeyEvent
    {
        Down,
        Up
    }

    class JoyButton
    {
        public Keys Key { get; private set; }
        public int Id { get; private set; }
        bool pressed = false;

        public bool Pressed {
            get => pressed;
            set
            {
                if (pressed == value)
                    return;
                pressed = value;
                var pressedStr = (value ? KeyEvent.Down : KeyEvent.Up).ToString ();
                webSocket.Send(pressedStr + "|" + Key.ToString());
            }
        }

        WebSocket webSocket;
        public JoyButton (WebSocket webSocket, int id, Keys key)
        {
            this.Key = key;
            this.Id = id;
            this.webSocket = webSocket;
        }
    }
}
