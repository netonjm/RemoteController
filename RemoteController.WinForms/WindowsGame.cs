namespace RemoteController
{
    public abstract class WindowsGame : Game
    {
        abstract public string ClassName { get; }
        abstract public string WindowName { get; }
    }
}
