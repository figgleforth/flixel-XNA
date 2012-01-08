using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace fliXNA_xbox
{
    public class Driller : FlxState
    {
        private TestHouse house;
        private FlxSprite houseSprite;
        private Player p;

        public override void create()
        {
            base.create();

            FlxG.bgColor = FlxColor.SILK;

            house = new TestHouse();
            houseSprite = new FlxSprite();
            houseSprite.makeGraphic(100, 100, FlxColor.RED);
            add(houseSprite);
            add(house);

            p = new Player(200, 200);
            add(p.footsteps);
            add(p);

            house.associateWithEntity(p);


            FlxG.camera.follow(p, FlxCamera.STYLE_TOPDOWN);
        }



        public override void update()
        {
            base.update();
            if (houseSprite.overlaps(p))
                house.inside = true;
            else
                house.inside = false;

        }

        public bool interactWithMap(FlxObject player, FlxObject map)
        {



            return true;
        }

    }
}
