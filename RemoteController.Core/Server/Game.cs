namespace RemoteController
{
    public abstract class WindowsGame : Game
    {
        abstract public string ClassName { get; }
        abstract public string WindowName { get; }
    }

    public abstract class Game
    {
        abstract public string ExecutableFilePath { get; }
    
        abstract public string DisplayName { get; }
    }
}
