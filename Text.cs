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
    public class Text : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var layer = GetLayer("text");

            var title11 = layer.CreateSprite("sb/title/title11.png");
            title11.Scale(0, 0.6f);
            title11.Color(0, new Color4(0, 0, 0, 0));
            title11.Fade(OsbEasing.InCirc, 2176, 2176 + 200, 0, 1);
            title11.Fade(OsbEasing.OutSine, 10085, 10630, 1, 0);

            var title12 = layer.CreateSprite("sb/title/title12.png");
            title12.Scale(0, 0.6f);
            title12.Color(0, new Color4(0, 0, 0, 0));
            title12.Fade(OsbEasing.InCirc, 6539, 6539 + 200, 0, 1);
            title12.Fade(OsbEasing.OutSine, 10085, 10630, 1, 0);

            var title13 = layer.CreateSprite("sb/title/title13.png");
            title13.Scale(0, 0.6f);
            title13.Color(0, new Color4(0, 0, 0, 0));
            title13.Fade(OsbEasing.InCirc, 8721, 8721 + 200, 0, 1);
            title13.Fade(OsbEasing.OutSine, 10085, 10630, 1, 0);

            var title21 = layer.CreateSprite("sb/title/title21.png");
            title21.Scale(0, 0.6f);
            title21.Color(0, new Color4(0, 0, 0, 0));
            title21.Fade(OsbEasing.InCirc, 10903, 10903 + 200, 0, 1);
            title21.Fade(OsbEasing.OutSine, 16903, 18539, 1, 0);

            var title22 = layer.CreateSprite("sb/title/title22.png");
            title22.Scale(0, 0.6f);
            title22.Color(0, new Color4(0, 0, 0, 0));
            title22.Fade(OsbEasing.InCirc, 10903, 10903 + 200, 0, 1);
            title22.Fade(OsbEasing.OutSine, 16903, 18539, 1, 0);

        }
    }
}
