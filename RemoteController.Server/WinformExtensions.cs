namespace KeyRead
{
    public static class WinformExtensions
    {
        public static System.Windows.Forms.Keys ToWinformsKey(this RemoteController.Keys keys)
        {
            return (System.Windows.Forms.Keys)(int)keys;
        }
    }
}
