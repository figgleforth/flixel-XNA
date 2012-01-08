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
        private FlxSprite blackout;
        private FlxSprite houseSprite;
        private Player p;

        private FlxGroup houseBases;    //will contain the sprite for the floors of each house
        private FlxGroup houseRooves;   //will contain rooves

        public override void create()
        {
            base.create();

            houseBases = new FlxGroup();
            houseRooves = new FlxGroup();

            FlxG.bgColor = FlxColor.INDIGO;
            blackout = new FlxSprite();
            blackout.makeGraphic(FlxG.width, FlxG.height, FlxColor.BLACK);
            blackout.visible = false;
            add(blackout);

            houseSprite = new FlxSprite(500, 500);
            houseSprite.makeGraphic(800, 800, FlxColor.BROWN);
            add(houseSprite);

            p = new Player(200, 200);
            add(p.footsteps);
            add(p);



            FlxG.camera.follow(p, FlxCamera.STYLE_TOPDOWN);
        }



        public override void update()
        {
            base.update();
            onPlayer();
            //if (houseSprite.overlaps(p))
            //    house.inside = true;
            //else
            //    house.inside = false;
           

        }

        public bool interactWithMap(FlxObject player, FlxObject map)
        {



            return true;
        }

        private void onPlayer()
        {
            blackout.x = FlxG.camera.scroll.x;
            blackout.y = FlxG.camera.scroll.y;
            if (!FlxG.overlap(houseSprite, p))
            {
                blackout.visible = false;
                p.indoors = false;
            }
            else
            {
                blackout.visible = true;
                p.indoors = true;
            }
        }

    }
}
