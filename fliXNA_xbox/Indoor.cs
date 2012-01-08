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
    public class Indoor : FlxGroup
    {
        private FlxSprite _bg;
        private Color _bgColor;
        private bool _inside;
        public FlxObject _target;
        
        public Indoor(Color BackgroundColor, float X, float Y)
            : base()
        {
            _bgColor = BackgroundColor;
            x = X;
            y = Y;

            _inside = false;
            _target = null;

            //create the color flush and make its center the center of this group
            _bg = new FlxSprite();
            _bg.makeGraphic(FlxG.width * 2, FlxG.height * 2, _bgColor);
            _bg.x = x - (_bg.width / 2);
            _bg.y = y - (_bg.height / 2);

            add(_bg);
        }

        public bool inside
        {
            get { return _inside; }
            set { _inside = value; }
        }

        public void associateWithEntity(FlxObject PlayerOrObject)
        {
            _target = PlayerOrObject;
        }
    }
}
