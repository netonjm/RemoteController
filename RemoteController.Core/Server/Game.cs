namespace RemoteController
{
    public abstract class Game
    {
        abstract public string ExecutableFilePath { get; }
    
        abstract public string DisplayName { get; }
    }
}
