using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fliXNA_xbox
{
    public class ZeldaCam : FlxSprite
    {

        public FlxObject target;
        private FlxRect screen;

        public ZeldaCam(FlxObject Target)
            : base()
        {
            target = Target;

            //center the target
            x = target.x;// -(FlxG.width / 2);
            y = target.y;// -(FlxG.height / 2);

            screen = new FlxRect(x, y, x + FlxG.width, y + FlxG.height);
        }

        public override void update()
        {
            base.update();

            if (target.x >= screen.right)
                x += FlxG.width/2;
            if (target.y >= screen.bottom)
                y += FlxG.height/2;
            if (target.x <= screen.left)
                x -= FlxG.width/2;
            if (target.y <= screen.top)
                y -= FlxG.height/2;

        }



    }
}
