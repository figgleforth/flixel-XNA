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
    public class Player : FlxSprite
    {
        private float vel = 50;
        public FlxSprite checker;
        private float makePathTimer = 0;
        private FlxPath _path;
        private List<FlxPoint> _nodes;
        private FlxPoint _currPos;
        private FlxPoint _lastPos;

        public Player(int X = 0, int Y = 0)
            : base(X, Y)
        {
            maxVelocity = new FlxPoint(100, 100);
            drag = new FlxPoint(500, 500);
            makeGraphic(40, 40, FlxColor.WHITE);

            _currPos = new FlxPoint(x, y);
            _lastPos = new FlxPoint(x, y);
            _nodes = new List<FlxPoint>();
            _nodes.Add(_lastPos);
            _nodes.Add(_currPos);
            _path = new FlxPath(_nodes);
        }

        public override void update()
        {
            base.update();
            pathLogic();



            if (FlxG.pad1.leftAnalogPushedRight())
            {
                facing = RIGHT;
                velocity.x += (vel * FlxG.pad1.leftAnalogX);
            }
            else if (FlxG.pad1.leftAnalogPushedLeft())
            {
                facing = LEFT;
                velocity.x += (vel * FlxG.pad1.leftAnalogX);
            }

            else if (FlxG.pad1.leftAnalogPushedUp())
            {
                facing = UP;
                velocity.y -= (vel * FlxG.pad1.leftAnalogY);
            }
            else if (FlxG.pad1.leftAnalogPushedDown())
            {
                facing = DOWN;
                velocity.y -= (vel * FlxG.pad1.leftAnalogY);
            }


        }

        private void pathLogic()
        {
            _currPos.make(x, y);

            if (moving)
                makePathTimer += FlxG.elapsed;
            if (makePathTimer >= 3)
            {
                if (FlxU.getDistance(_currPos, _lastPos) >= 10)
                {
                    //FlxG.log(FlxU.getDistance(_currPos, _lastPos));
                    _lastPos.make(x, y) ;
                    _nodes.Add(_lastPos);
                    //FlxG.log("+node at ("+_currPos.x+", "+_currPos.y+")");
                }
                makePathTimer = 0;
            }
        }

        public FlxPath getPath()
        {
            return _path;
        }
    }
}
