using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Mapset;
using StorybrewCommon.Scripting;
using StorybrewCommon.Storyboarding;
using StorybrewCommon.Storyboarding.Util;
using StorybrewCommon.Subtitles;
using StorybrewCommon.Util;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StorybrewScripts
{
    public class Overlay : StoryboardObjectGenerator
    {
        public override void Generate()
        {

            var layer = GetLayer("Overlay");
            var starttime = 116717;
            var endtime = 124098;

            var bit = GetMapsetBitmap("sb/overlay_align.jpeg");
            var overlay = layer.CreateSprite("sb/overlay_align.jpeg", OsbOrigin.Centre, new Vector2(320, 240));
            overlay.ScaleVec(starttime, 640f / bit.Width, 480f / bit.Height);
            overlay.Fade(starttime, 0.2);
            overlay.Fade(endtime, 0);
		    
            
        }
    }
}
