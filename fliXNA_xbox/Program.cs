using System;

namespace fliXNA_xbox
{
#if WINDOWS || XBOX
    static class Program
    {
        static void Main(string[] args)
        {
            using (FlxGame game = new FlxGame(new Sandbox1(), 1280, 720, 1f))
            {
                game.Run();
            }
        }
    }
#endif
}

