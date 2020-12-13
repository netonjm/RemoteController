using System;

namespace RemoteController
{
    public class JoyButton
    {
        public event EventHandler Pressed;
        public Keys Key { get; private set; }
        public int Id { get; private set; }
        bool pressed = false;

        public bool IsPressed {
            get => pressed;
            set
            {
                if (pressed == value)
                    return;
                pressed = value;
                Pressed?.Invoke(this, EventArgs.Empty);
            }
        }

        public JoyButton (int id, Keys key)
        {
            this.Key = key;
            this.Id = id;
        }
    }
}
