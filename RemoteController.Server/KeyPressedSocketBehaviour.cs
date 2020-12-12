using System;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace KeyRead
{
    public class KeyPressedSocketBehaviour : WebSocketBehavior
    {
        KeyService keyManager;
        public KeyPressedSocketBehaviour(KeyService keyManager)
        {
            this.keyManager = keyManager;
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
                        if (gameNumber == 0)
                        {
                            if (!(keyManager.CurrentGame is VPPlayerGame))
                            {
                                keyManager.CurrentGame = new VPPlayerGame();

                            }
                        } 
                        else if (gameNumber == 1)
                        {
                            if (!(keyManager.CurrentGame is VPPlayerGame))
                            {
                                keyManager.CurrentGame = new VPPlayerGame();
                            }
                        } 
                        else
                        {

                        }
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

                if (Enum.TryParse(split[0], out KeyEvent keyEvent) && Enum.TryParse(split[1], out System.Windows.Forms.Keys myStatus))
                {
                    keyManager.SendKey(keyEvent, myStatus);
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
