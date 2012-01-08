using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fliXNA_xbox
{
    public class TestHouse : Indoor
    {

        FlxSprite floor;

        public TestHouse()
            : base(FlxColor.BLACK, 0, 0)
        {
            visible = false;
            floor = new FlxSprite();
            floor.makeGraphic(800, 500, FlxColor.SILK);
            add(floor);
        }

        public override void update()
        {
            base.update();
            if (_target != null)
            {
                if (!FlxG.overlap(floor, _target, getInside))
                    visible = false;
            }
        }

        public bool getInside(FlxObject f, FlxObject t)
        {
            visible = true;
            return true;
        }
    }
}
