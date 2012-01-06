using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fliXNA_xbox
{
    public class TitleState : FlxState
    {

        public FlxText title;


        public override void create()
        {
            base.create();
            FlxG.bgColor = FlxColor.BLUE;

            title = new FlxText(FlxG.safeZone.midX, FlxG.safeZone.top, FlxG.safeZone.width, "1");
            title.setFormat(FlxColor.WHITE, 2f);
            add(title);

            //title.centerOnPoint(new FlxPoint(FlxG.safeZone.midX, FlxG.safeZone.midY));
        }

        public override void update()
        {
            base.update();
           // title.text = FlxG.dateTime.Second.ToString();





        }
    }
}
