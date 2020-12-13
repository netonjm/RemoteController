namespace RemoteController
{
    public interface IGameService
    {
        Game CurrentGame { get; set; }
        void SendKey(KeyEvent ev, RemoteController.Keys v);
        void SetCurrentGame(int gameNumber);
    }
}
