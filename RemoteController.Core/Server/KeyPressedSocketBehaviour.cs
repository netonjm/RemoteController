using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace RemoteController
{
    public class KeyPressedSocketBehaviour : WebSocketBehavior
    {
        IGameService gameService;
        public KeyPressedSocketBehaviour(IGameService keyManager)
        {
            this.gameService = keyManager;
        }

        protected override void OnMessage(MessageEventArgs e)
        {
            if (e.Data == "PING")
            {
                Send("PONG");
                return;
            }

            if (e.Data.StartsWith ("GAME|"))
            {
                try
                {
                    var rest = e.Data.Substring("GAME|".Length);
                    if (int.TryParse (rest, out var gameNumber))
                    {
                        gameService.SetCurrentGame(gameNumber);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
                return;
            }

            try
            {
                var split = e.Data.Split('|');

                if (Enum.TryParse(split[0], out KeyEvent keyEvent) && Enum.TryParse(split[1], out Keys myStatus))
                {
                    gameService.SendKey(keyEvent, myStatus);
                } 
            }
            catch (Exception)
            {
            }
            //StreamReader reader = new StreamReader(e.Data);
            //string text = reader.ReadToEnd();
            //var msg = text == "BALUS"
            //          ? "I've been balused already..."
            //          : "I'm not available now.";

            //Send(msg);
        }
    }
}
