using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fliXNA_xbox
{
    public class Building : FlxSprite
    {

        private FlxSprite _floor;
        private FlxSprite _roof;
        private Player _player;
        private FlxSprite _blackout;

        public Building(float X, float Y, float Width, float Height, Player Player, FlxSprite Blackout)
            : base(X, Y)
        {
            makeGraphic(Width, Height, FlxColor.GOLD);

            _blackout = Blackout;
            _player = Player;
            //_floor = new FlxSprite(X, Y);
            //_floor.makeGraphic(Width, Height, FlxColor.BROWN);
            _roof = new FlxSprite(X, Y);
            _roof.makeGraphic(Width, Height, FlxColor.CRIMSON);
            visible = _roof.visible = false;
        }

        public override void update()
        {
            base.update();
            if (overlaps(_player))
            {
                visible = true;
                _roof.visible = false;
                _blackout.visible = true;
                _player.indoors = true;
            }
            else
            {
                visible = false;
                _roof.visible = true;
                _blackout.visible = false;
                _player.indoors = false;
            }
        }

        public FlxSprite floor
        {
            get { return this; }
        }

        public FlxSprite roof
        {
            get { return _roof; }
        }


    }
}
