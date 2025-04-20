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
    public class Bg : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            RemoveBackground();

            var top = GetLayer("top");
            var bg = GetLayer("bg");
            var paperLayer = GetLayer("paperLayer");

            var bgFrameBit = GetMapsetBitmap("sb/white.png");
            var bgFrame = bg.CreateSprite("sb/white.png");
            bgFrame.Fade(0, 1);
            bgFrame.Fade(140636, 0);
            bgFrame.ScaleVec(0, new Vector2(460 / 3 * 4, 460));
            bgFrame.Color(0, new Color4(238, 220, 206, 255));

            var paperBit = GetMapsetBitmap("sb/paper.png");
            var paper = paperLayer.CreateSprite("sb/paper.png");
            paper.Fade(0, .3f);
            //paper.Color(0, new Color4(81, 167, 157, 255));
            //paper.Additive(0);
            paper.Fade(140636, 0);

            var baseScale = new Vector2(460f / 3 * 4 / paperBit.Width, 460f / paperBit.Height);
            paper.ScaleVec(0, baseScale);
            paper.Rotate(0, 0);

            paper.StartLoopGroup(0, 140585 / 800);
            paper.ScaleVec(200, baseScale.Y, baseScale.X);
            paper.Rotate(200, -Math.PI / 2);

            paper.ScaleVec(400, baseScale.X, baseScale.Y);
            paper.Rotate(400, Math.PI);

            paper.ScaleVec(600, baseScale.X, baseScale.Y);
            paper.Rotate(600, 0);

            paper.ScaleVec(800, -baseScale.X, baseScale.Y);
            paper.Rotate(800, Math.PI);

            paper.ScaleVec(1000, baseScale.X, baseScale.Y);
            paper.Rotate(1000, 0);
            paper.EndGroup();

            var topCoverBottom = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 0));
            topCoverBottom.Fade(0, 1);
            topCoverBottom.Fade(140636, 0);
            topCoverBottom.Color(0, new Color4(40, 40, 40, 255));
            topCoverBottom.ScaleVec(0, new Vector2(612f, 32f));

            var topCover = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 0));
            topCover.Fade(0, 1);
            topCover.Fade(140636, 0);
            topCover.Color(0, new Color4(50, 50, 50, 255));
            topCover.ScaleVec(0, new Vector2(854f, 28f));

            var leftCoverBottom = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(-100, 240));
            leftCoverBottom.Fade(0, 1);
            leftCoverBottom.Fade(140636, 0);
            leftCoverBottom.Color(0, new Color4(40, 40, 40, 255));
            leftCoverBottom.ScaleVec(0, new Vector2(232, 450f));

            var leftCover = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(-100, 240));
            leftCover.Fade(0, 1);
            leftCover.Fade(140636, 0);
            leftCover.Color(0, new Color4(50, 50, 50, 255));
            leftCover.ScaleVec(0, new Vector2(228f, 480f));

            var rightCoverBottom = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(740, 240));
            rightCoverBottom.Fade(0, 1);
            rightCoverBottom.Fade(140636, 0);
            rightCoverBottom.Color(0, new Color4(40, 40, 40, 255));
            rightCoverBottom.ScaleVec(0, new Vector2(232, 450f));

            var rightCover = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(740, 240));
            rightCover.Fade(0, 1);
            rightCover.Fade(140636, 0);
            rightCover.Color(0, new Color4(50, 50, 50, 255));
            rightCover.ScaleVec(0, new Vector2(228f, 480f));

            var bottomCoverBottom = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 480));
            bottomCoverBottom.Fade(0, 1);
            bottomCoverBottom.Fade(140636, 0);
            bottomCoverBottom.Color(0, new Color4(40, 40, 40, 255));
            bottomCoverBottom.ScaleVec(0, new Vector2(612f, 32f));

            var bottomCover = top.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 480));
            bottomCover.Fade(0, 1);
            bottomCover.Fade(140636, 0);
            bottomCover.Color(0, new Color4(50, 50, 50, 255));
            bottomCover.ScaleVec(0, new Vector2(854f, 28f));

        }

        public void RemoveBackground() => GetLayer("").CreateSprite(Beatmap.BackgroundPath).Fade(0, 0);
    }
}
