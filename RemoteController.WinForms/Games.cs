using RemoteController;

namespace RemoteController.Server
{
    public class VPPlayerGame : WindowsGame
    {
        public override string ClassName => "VPPlayer";
        public override string WindowName => "Visual Pinball Player";
        public override string ExecutableFilePath => @"C:\Visual Pinball\VPinballX.exe";

        public override string DisplayName => "VPinball";
    }

    public class VRVPPlayerGame : WindowsGame
    {
        public override string ClassName => "SDL_app";
        public override string WindowName => "Visual Pinball Player SDL";

        public override string ExecutableFilePath => @"C:\Visual Pinball\VPinballX_GL.exe";

        public override string DisplayName => "VR-VPinball";
    }
}
