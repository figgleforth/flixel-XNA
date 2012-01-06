using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace fliXNA_xbox
{
    public class Follower : FlxSprite
    {

        private FlxPath follow;
        private Player player;

        public Follower(Player P)
            : base()
        {
            player = P;
            follow = P.getPath();
            x = P.x;
            y = P.y;
            makeGraphic(30, 30, FlxColor.LIME);
            followPath(follow, 75, FlxObject.PATH_FORWARD);
            //stopFollowingPath();
        }

        public override void update()
        {
            base.update();




        }

    }
}
