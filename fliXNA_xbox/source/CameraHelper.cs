using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fliXNA_xbox
{
    public class CameraHelper : FlxSprite
	{
		protected FlxSprite _player;
		protected FlxPoint _target;

		public CameraHelper(FlxSprite PlayerRef) : base()
		{
			_player = PlayerRef;
			_target = new FlxPoint();
			checkTarget();
			x = _target.x - width*0.5f;
			y = _target.y - height*0.5f;
            List<FlxPoint> nodes = new List<FlxPoint>();
            nodes.Add(new FlxPoint());
            nodes.Add(new FlxPoint());
			path = new FlxPath(nodes);
		}

		override public void update()
		{
			preUpdate();

			if(pathSpeed == 0)
			{
				velocity.x = velocity.y = 0;
				checkTarget();
				if((x + width*0.5 != _target.x) || (y + height*0.5 != _target.y))
				{
					path.nodes[0].x = x + width*0.5f;
					path.nodes[0].y = y + height*0.5f;
					path.nodes[1].x = _target.x;
					path.nodes[1].y = _target.y;
					followPath(path,300);
				}
			}

			postUpdate();
		}

		protected void checkTarget()
		{
            int px = (int)_player.x;
			if(_player.velocity.x < 0)
				px += 16;
            int py = (int)_player.y;
			if(_player.velocity.y < 0)
				py += 16;
			_target.x = (int)(px / FlxG.width) * FlxG.width + FlxG.width * 0.5f;
            _target.y = (int)(py / FlxG.height) * FlxG.height + FlxG.height * 0.5f;
		}
	}
}
