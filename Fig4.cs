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
    public class Fig4 : StoryboardObjectGenerator
    {

        public override void Generate()
        {
            var textlayer = GetLayer("text");
            var fLayer = GetLayer("fLayer");

            var topLeft = new Vector2(320 - 28, 240 - 5);
            var topRight = new Vector2(320 + 5, 240 - 28);
            var bottomLeft = new Vector2(320 - 5, 240 + 28);
            var bottomRight = new Vector2(320 + 28, 240 + 5);


            var dots = GetLayer("back").CreateSprite("sb/dots_falloff.png");
            dots.Scale(63266, 0.175);
            dots.Color(63266, new Color4(89, 82, 76, 255));
            dots.Fade(OsbEasing.InSine, 63266, 63539, 0, 1);
            dots.Fade(OsbEasing.OutSine, 78539, 79357, 1, 0);

            var figure = textlayer.CreateSprite("sb/figure/caption4.png", OsbOrigin.Centre, new Vector2(320, 450));
            figure.Scale(63266, 0.25);
            figure.Fade(OsbEasing.InSine, 63266, 63539, 0, 1);
            figure.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);
            figure.Color(63266, new Color4(0, 0, 0, 0));

            var blockOutLine0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topLeft);
            var blockTop0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topLeft);
            var blockHitOutline0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topLeft);
            var blockHitType0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topLeft);

            blockTop0.ScaleVec(63266, new Vector2(50f, 9f));
            blockTop0.Rotate(63266, -Math.PI / 4);
            blockTop0.Color(63266, new Color4(95, 93, 92, 255));
            blockTop0.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockTop0.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockOutLine0.ScaleVec(63266, new Vector2(52, 11f));
            blockOutLine0.Rotate(63266, -Math.PI / 4);
            blockOutLine0.Color(63266, new Color4(0, 0, 0, 255));
            blockOutLine0.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockOutLine0.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitOutline0.Scale(63266, 7f);
            blockHitOutline0.Color(63266, new Color4(0, 0, 0, 255));
            blockHitOutline0.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitOutline0.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitType0.Scale(63266, 5f);
            blockHitType0.Color(63266, new Color4(151, 78, 86, 255));
            blockHitType0.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitType0.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            var blockOutLine1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topRight);
            var blockTop1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topRight);
            var blockHitOutline1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topRight);
            var blockHitTyp1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, topRight);

            blockTop1.ScaleVec(63266, new Vector2(50f, 9f));
            blockTop1.Rotate(63266, Math.PI / 4);
            blockTop1.Color(63266, new Color4(95, 93, 92, 255));
            blockTop1.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockTop1.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockOutLine1.ScaleVec(63266, new Vector2(52, 11f));
            blockOutLine1.Rotate(63266, Math.PI / 4);
            blockOutLine1.Color(63266, new Color4(0, 0, 0, 255));
            blockOutLine1.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockOutLine1.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitOutline1.Scale(63266, 7f);
            blockHitOutline1.Color(63266, new Color4(0, 0, 0, 255));
            blockHitOutline1.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitOutline1.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitTyp1.Scale(63266, 5f);
            blockHitTyp1.Color(63266, new Color4(151, 78, 86, 255));
            blockHitTyp1.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitTyp1.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            var blockOutLine2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomLeft);
            var blockTop2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomLeft);
            var blockHitOutline2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomLeft);
            var blockHitType2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomLeft);

            blockTop2.ScaleVec(63266, new Vector2(50f, 9f));
            blockTop2.Rotate(63266, Math.PI / 4);
            blockTop2.Color(63266, new Color4(95, 93, 92, 255));
            blockTop2.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockTop2.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockOutLine2.ScaleVec(63266, new Vector2(52, 11f));
            blockOutLine2.Rotate(63266, Math.PI / 4);
            blockOutLine2.Color(63266, new Color4(0, 0, 0, 255));
            blockOutLine2.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockOutLine2.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitOutline2.Scale(63266, 7f);
            blockHitOutline2.Color(63266, new Color4(0, 0, 0, 255));
            blockHitOutline2.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitOutline2.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitType2.Scale(63266, 5f);
            blockHitType2.Color(63266, new Color4(151, 78, 86, 255));
            blockHitType2.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitType2.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            var blockOutLine3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomRight);
            var blockTop3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomRight);
            var blockHitOutline3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomRight);
            var blockHitType3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, bottomRight);

            blockTop3.ScaleVec(63266, new Vector2(50f, 9f));
            blockTop3.Rotate(63266, -Math.PI / 4);
            blockTop3.Color(63266, new Color4(95, 93, 92, 255));
            blockTop3.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockTop3.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockOutLine3.ScaleVec(63266, new Vector2(52.5f, 11f));
            blockOutLine3.Rotate(63266, -Math.PI / 4);
            blockOutLine3.Color(63266, new Color4(0, 0, 0, 255));
            blockOutLine3.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockOutLine3.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitOutline3.Scale(63266, 7f);
            blockHitOutline3.Color(63266, new Color4(0, 0, 0, 255));
            blockHitOutline3.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitOutline3.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);

            blockHitType3.Scale(63266, 5f);
            blockHitType3.Color(63266, new Color4(151, 78, 86, 255));
            blockHitType3.Fade(OsbEasing.InSine, 63266, 63539, 0, 1f);
            blockHitType3.Fade(OsbEasing.OutSine, 78539, 79357, 1f, 0);


            LaunchBall(BallLaunch.top, BallLaunch.right, topRight, 64357);
            LaunchBall(BallLaunch.bottom, BallLaunch.left, bottomLeft, 65448);
            LaunchBall(BallLaunch.right, BallLaunch.bottom, bottomRight, 66539);
            LaunchBall(BallLaunch.left, BallLaunch.top, topLeft, 67630);
            LaunchBall(BallLaunch.top, BallLaunch.right, topRight, 69266);
            LaunchBall(BallLaunch.left, BallLaunch.top, topLeft, 69812);
            LaunchBall(BallLaunch.right, BallLaunch.bottom, bottomRight, 70357);
            LaunchBall(BallLaunch.bottom, BallLaunch.left, bottomLeft, 70903);
            LaunchBall(BallLaunch.top, BallLaunch.right, topRight, 71448);
            LaunchBall(BallLaunch.left, BallLaunch.top, topLeft, 71994);
            LaunchBall(BallLaunch.bottom, BallLaunch.right, bottomRight, 73085);
            LaunchBall(BallLaunch.left, BallLaunch.bottom, bottomLeft, 74176);
            LaunchBall(BallLaunch.right, BallLaunch.top, topRight, 75266);
            LaunchBall(BallLaunch.top, BallLaunch.left, topLeft, 76357);
            LaunchBall(BallLaunch.bottom, BallLaunch.right, bottomRight, 77448);
            LaunchBall(BallLaunch.bottom, BallLaunch.left, bottomLeft, 77994);
            LaunchBall(BallLaunch.top, BallLaunch.right, topRight, 78539);

        }

        public void LaunchBall(BallLaunch launchOrigin, BallLaunch direction, Vector2 rootCord, double beatTime)
        {
            var scale = 0.12f;
            var scaleFilling = 0.1f;
            var ballBit = GetMapsetBitmap("sb/ball.png");
            var ballWidht = scale * ballBit.Width;
            var halfWidht = ballWidht / 2;

            var ball = GetLayer("fLayer").CreateSprite("sb/ball.png", OsbOrigin.Centre, rootCord);
            var ballFilling = GetLayer("fLayer").CreateSprite("sb/ball.png", OsbOrigin.Centre, rootCord);

            switch (launchOrigin)
            {
                case BallLaunch.top:
                    rootCord.Y -= 150f + halfWidht;
                    break;
                case BallLaunch.left:
                    rootCord.X -= 150f + halfWidht;
                    break;
                case BallLaunch.right:
                    rootCord.X += 150f + halfWidht;
                    break;
                case BallLaunch.bottom:
                    rootCord.Y += 150f + halfWidht;
                    break;
            }

            switch (launchOrigin)
            {
                case BallLaunch.top:
                    switch (direction)
                    {
                        case BallLaunch.top:
                            break;
                        case BallLaunch.left:
                            rootCord.X -= halfWidht;
                            break;
                        case BallLaunch.right:
                            rootCord.X += halfWidht;
                            break;
                        case BallLaunch.bottom:
                            break;

                    }
                    break;
                case BallLaunch.left:
                    switch (direction)
                    {
                        case BallLaunch.top:
                            rootCord.Y -= halfWidht;
                            break;
                        case BallLaunch.left:
                            rootCord.Y += halfWidht;
                            break;
                        case BallLaunch.right:
                            rootCord.Y -= halfWidht;
                            break;
                        case BallLaunch.bottom:
                            rootCord.Y += halfWidht;
                            break;

                    }
                    break;
                case BallLaunch.right:
                    switch (direction)
                    {
                        case BallLaunch.top:
                            rootCord.Y -= halfWidht;
                            break;
                        case BallLaunch.left:
                            rootCord.Y -= halfWidht;
                            break;
                        case BallLaunch.right:
                            rootCord.Y += halfWidht;
                            break;
                        case BallLaunch.bottom:
                            rootCord.Y += halfWidht;
                            break;

                    }
                    break;
                case BallLaunch.bottom:
                    switch (direction)
                    {
                        case BallLaunch.top:
                            break;
                        case BallLaunch.left:
                            rootCord.X -= halfWidht;
                            break;
                        case BallLaunch.right:
                            rootCord.X += halfWidht;
                            break;
                        case BallLaunch.bottom:
                            break;

                    }
                    break;

            }

            ball.Scale(beatTime - 1000, scale);
            ball.Color(beatTime - 1000, new Color4(0, 0, 0, 0));
            ball.Fade(OsbEasing.InSine, beatTime - 1000, beatTime - 300, 0, 1);
            ball.Fade(OsbEasing.OutSine, beatTime, beatTime + 500, 1, 0);

            ballFilling.Scale(beatTime - 1000, scaleFilling);
            ballFilling.Color(beatTime - 1000, new Color4(95, 93, 92, 0));
            ballFilling.Fade(OsbEasing.InSine, beatTime - 1000, beatTime - 300, 0, 1);
            ballFilling.Fade(OsbEasing.OutSine, beatTime, beatTime + 500, 1, 0);

            switch (launchOrigin)
            {
                case BallLaunch.top:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y + 150f);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y + 150f);
                    break;
                case BallLaunch.left:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X + 150f, rootCord.Y);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X + 150f, rootCord.Y);
                    break;
                case BallLaunch.right:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X - 150f, rootCord.Y);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X - 150f, rootCord.Y);
                    break;
                case BallLaunch.bottom:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y - 150f);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y - 150f);
                    break;
            }

            switch (direction)
            {
                case BallLaunch.top:
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(0, 150f + halfWidht));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(0, 150f + halfWidht));
                    break;
                case BallLaunch.left:
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(150f + halfWidht, 0));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(150f + halfWidht, 0));
                    break;
                case BallLaunch.right:
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(150f + halfWidht, 0));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(150f + halfWidht, 0));
                    break;
                case BallLaunch.bottom:
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(0, 150f + halfWidht));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(0, 150f + halfWidht));
                    break;
            }

        }
    }
}
