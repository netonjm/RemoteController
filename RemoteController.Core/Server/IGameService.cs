using System;

namespace RemoteController
{
    public interface IGameService
    {
        event EventHandler GameChanged;
        Game CurrentGame { get; set; }

        void SendKey(KeyEvent ev, RemoteController.Keys v);
        void SetCurrentGame(int gameNumber);
        void StartCurrentGame();
    }
}
