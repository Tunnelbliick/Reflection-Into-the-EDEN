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

    public class Fig1 : StoryboardObjectGenerator
    {
        public override void Generate()
        {

            var textlayer = GetLayer("text");
            var fLayer = GetLayer("fLayer");

            var topLeft = new Vector2(320 - 85, 150);
            var topRight = new Vector2(320 + 85, 150);
            var bottomLeft = new Vector2(320 - 85, 320);
            var bottomRight = new Vector2(320 + 85, 320);

            var figure = textlayer.CreateSprite("sb/figure/caption1.png", OsbOrigin.BottomLeft, new Vector2(320 - 150 - 20, 73));
            figure.Scale(17448, 0.25);
            figure.Fade(OsbEasing.InSine, 17448, 18539, 0, 1);
            figure.Fade(OsbEasing.OutSine, 34903, 35994, 1, 0);
            figure.Color(17448, new Color4(0, 0, 0, 0));

            var dotBit = GetMapsetBitmap("sb/dots.png");
            var dots0 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, new Vector2(320 - 85, 150));
            dots0.ScaleVec(17448, new Vector2(150f / dotBit.Width));
            dots0.Color(17448, new Color4(89, 82, 76, 0));
            dots0.Fade(OsbEasing.InSine, 17448, 18539, 0, 1);
            dots0.Fade(OsbEasing.OutSine, 34903, 35994, 1, 0);

            var dots1 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, new Vector2(320 + 85, 150));
            dots1.ScaleVec(17448, new Vector2(150f / dotBit.Width));
            dots1.Color(17448, new Color4(89, 82, 76, 0));
            dots1.Fade(OsbEasing.InSine, 17448, 18539, 0, 1);
            dots1.Fade(OsbEasing.OutSine, 34903, 35994, 1, 0);

            var dots2 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, new Vector2(320 - 85, 320));
            dots2.ScaleVec(17448, new Vector2(150f / dotBit.Width));
            dots2.Color(17448, new Color4(89, 82, 76, 0));
            dots2.Fade(OsbEasing.InSine, 17448, 18539, 0, 1);
            dots2.Fade(OsbEasing.OutSine, 34903, 35994, 1, 0);

            var dots3 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, new Vector2(320 + 85, 320));
            dots3.ScaleVec(17448, new Vector2(150f / dotBit.Width));
            dots3.Color(17448, new Color4(89, 82, 76, 0));
            dots3.Fade(OsbEasing.InSine, 17448, 18539, 0, 1);
            dots3.Fade(OsbEasing.OutSine, 34903, 35994, 1, 0);

            var frame0 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, new Vector2(320 - 85, 150));
            frame0.ScaleVec(17448, new Vector2(400f / dotBit.Width));
            frame0.Color(17448, new Color4(0, 0, 0, 0));
            frame0.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            frame0.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var frame1 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, new Vector2(320 + 85, 150));
            frame1.ScaleVec(17448, new Vector2(400f / dotBit.Width));
            frame1.Color(17448, new Color4(0, 0, 0, 0));
            frame1.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            frame1.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var frame2 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, new Vector2(320 - 85, 320));
            frame2.ScaleVec(17448, new Vector2(400f / dotBit.Width));
            frame2.Color(17448, new Color4(0, 0, 0, 0));
            frame2.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            frame2.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var frame3 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, new Vector2(320 + 85, 320));
            frame3.ScaleVec(17448, new Vector2(400f / dotBit.Width));
            frame3.Color(17448, new Color4(0, 0, 0, 0));
            frame3.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            frame3.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var blockOutLine0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 150));
            var blockTop0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 150));
            var blockHitOutline0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 150));
            var blockHitType0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 150));

            blockTop0.ScaleVec(17448, new Vector2(50f, 7f));
            blockTop0.Rotate(0, -Math.PI / 4);
            blockTop0.Color(17448, new Color4(95, 93, 92, 255));
            blockTop0.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockTop0.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockOutLine0.ScaleVec(17448, new Vector2(52, 9.5f));
            blockOutLine0.Rotate(0, -Math.PI / 4);
            blockOutLine0.Color(17448, new Color4(0, 0, 0, 255));
            blockOutLine0.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockOutLine0.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitOutline0.Scale(17448, 6f);
            blockHitOutline0.Color(17448, new Color4(0, 0, 0, 255));
            blockHitOutline0.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitOutline0.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitType0.Scale(17448, 4f);
            blockHitType0.Color(17448, new Color4(255, 0, 47, 255));
            blockHitType0.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitType0.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var blockOutLine1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 150));
            var blockTop1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 150));
            var blockHitOutline1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 150));
            var blockHitTyp1 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 150));

            blockTop1.ScaleVec(17448, new Vector2(50f, 7f));
            blockTop1.Rotate(0, Math.PI / 4);
            blockTop1.Color(17448, new Color4(95, 93, 92, 255));
            blockTop1.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockTop1.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockOutLine1.ScaleVec(17448, new Vector2(52, 9.5f));
            blockOutLine1.Rotate(0, Math.PI / 4);
            blockOutLine1.Color(17448, new Color4(0, 0, 0, 255));
            blockOutLine1.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockOutLine1.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitOutline1.Scale(17448, 6f);
            blockHitOutline1.Color(17448, new Color4(0, 0, 0, 255));
            blockHitOutline1.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitOutline1.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitTyp1.Scale(17448, 4f);
            blockHitTyp1.Color(17448, new Color4(255, 0, 47, 255));
            blockHitTyp1.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitTyp1.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var blockOutLine2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 320));
            var blockTop2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 320));
            var blockHitOutline2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 320));
            var blockHitType2 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 - 85, 320));

            blockTop2.ScaleVec(17448, new Vector2(50f, 7f));
            blockTop2.Rotate(0, Math.PI / 4);
            blockTop2.Color(17448, new Color4(95, 93, 92, 255));
            blockTop2.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockTop2.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockOutLine2.ScaleVec(17448, new Vector2(52, 9.5f));
            blockOutLine2.Rotate(0, Math.PI / 4);
            blockOutLine2.Color(17448, new Color4(0, 0, 0, 255));
            blockOutLine2.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockOutLine2.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitOutline2.Scale(17448, 6f);
            blockHitOutline2.Color(17448, new Color4(0, 0, 0, 255));
            blockHitOutline2.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitOutline2.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitType2.Scale(17448, 4f);
            blockHitType2.Color(17448, new Color4(255, 0, 47, 255));
            blockHitType2.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitType2.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            var blockOutLine3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 320));
            var blockTop3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 320));
            var blockHitOutline3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 320));
            var blockHitType3 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320 + 85, 320));

            blockTop3.ScaleVec(17448, new Vector2(50f, 7f));
            blockTop3.Rotate(0, -Math.PI / 4);
            blockTop3.Color(17448, new Color4(95, 93, 92, 255));
            blockTop3.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockTop3.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockOutLine3.ScaleVec(17448, new Vector2(52.5f, 9.5f));
            blockOutLine3.Rotate(0, -Math.PI / 4);
            blockOutLine3.Color(17448, new Color4(0, 0, 0, 255));
            blockOutLine3.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockOutLine3.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitOutline3.Scale(17448, 6f);
            blockHitOutline3.Color(17448, new Color4(0, 0, 0, 255));
            blockHitOutline3.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitOutline3.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            blockHitType3.Scale(17448, 4f);
            blockHitType3.Color(17448, new Color4(255, 0, 47, 255));
            blockHitType3.Fade(OsbEasing.InSine, 17448, 18539, 0, 1f);
            blockHitType3.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            LaunchBall(BallLaunch.top, BallLaunch.left, topLeft, 19630);
            LaunchBall(BallLaunch.right, BallLaunch.top, topRight, 21266);
            LaunchBall(BallLaunch.left, BallLaunch.bottom, bottomLeft, 21812);
            LaunchBall(BallLaunch.bottom, BallLaunch.right, bottomRight, 22903);
            LaunchBall(BallLaunch.top, BallLaunch.left, topLeft, 23994);
            LaunchBall(BallLaunch.right, BallLaunch.bottom, bottomRight, 25630);
            LaunchBall(BallLaunch.left, BallLaunch.top, topLeft, 26176);
            LaunchBall(BallLaunch.top, BallLaunch.right, topRight, 26721);
            LaunchBall(BallLaunch.bottom, BallLaunch.left, bottomLeft, 27266);
            LaunchBall(BallLaunch.bottom, BallLaunch.right, bottomRight, 27812);
            LaunchBall(BallLaunch.top, BallLaunch.left, topLeft, 28357);
            LaunchBall(BallLaunch.right, BallLaunch.top, topRight, 29994);
            LaunchBall(BallLaunch.left, BallLaunch.bottom, bottomLeft, 30539);
            LaunchBall(BallLaunch.bottom, BallLaunch.right, bottomRight, 31630);
            LaunchBall(BallLaunch.left, BallLaunch.top, topLeft, 32721);
            LaunchBall(BallLaunch.right, BallLaunch.bottom, bottomRight, 34357);
            LaunchBall(BallLaunch.bottom, BallLaunch.left, bottomLeft, 34903);

        }

        public void LaunchBall(BallLaunch launchOrigin, BallLaunch direction, Vector2 rootCord, double beatTime)
        {
            var scale = 0.11f;
            var scaleFilling = 0.09f;
            var ballBit = GetMapsetBitmap("sb/ball.png");
            var ballWidht = scale * ballBit.Width;
            var halfWidht = ballWidht / 2 - 2f;

            var ball = GetLayer("fLayer").CreateSprite("sb/ball.png", OsbOrigin.Centre, rootCord);
            var ballFilling = GetLayer("fLayer").CreateSprite("sb/ball.png", OsbOrigin.Centre, rootCord);

            switch (launchOrigin)
            {
                case BallLaunch.top:
                    rootCord.Y -= 75f + halfWidht;
                    ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(scale, 0), new Vector2(scale, scale));
                    ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(scaleFilling, 0), new Vector2(scaleFilling, scaleFilling));
                    break;
                case BallLaunch.left:
                    rootCord.X -= 75f + halfWidht;
                    ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scale), new Vector2(scale, scale));
                    ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scaleFilling), new Vector2(scaleFilling, scaleFilling));
                    break;
                case BallLaunch.right:
                    rootCord.X += 75f + halfWidht;
                    ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scale), new Vector2(scale, scale));
                    ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scaleFilling), new Vector2(scaleFilling, scaleFilling));
                    break;
                case BallLaunch.bottom:
                    rootCord.Y += 75f + halfWidht;
                    ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(scale, 0), new Vector2(scale, scale));
                    ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scaleFilling), new Vector2(scaleFilling, scaleFilling));
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

            ball.Color(beatTime - 800, new Color4(0, 0, 0, 0));
            ball.Fade(beatTime - 800, beatTime - 760, 0, 1);
            ball.Fade(OsbEasing.OutSine, beatTime + 200, beatTime + 750, 1, 0);

            ballFilling.Color(beatTime - 800, new Color4(95, 93, 92, 0));
            ballFilling.Fade(beatTime - 800, beatTime - 760, 0, 1);
            ballFilling.Fade(OsbEasing.OutSine, beatTime + 200, beatTime + 750, 1, 0);

            switch (launchOrigin)
            {
                case BallLaunch.top:
                    ball.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y + 75f);
                    ballFilling.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y + 75f);
                    break;
                case BallLaunch.left:
                    ball.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X + 75f, rootCord.Y);
                    ballFilling.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X + 75f, rootCord.Y);
                    break;
                case BallLaunch.right:
                    ball.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X - 75f, rootCord.Y);
                    ballFilling.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X - 75f, rootCord.Y);
                    break;
                case BallLaunch.bottom:
                    ball.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y - 75f);
                    ballFilling.Move(beatTime - 800, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y - 75f);
                    break;
            }

            switch (direction)
            {
                case BallLaunch.top:
                    ball.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(0, 75f + halfWidht));
                    ballFilling.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(0, 75f + halfWidht));
                    break;
                case BallLaunch.left:
                    ball.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(75f + halfWidht, 0));
                    ballFilling.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(75f + halfWidht, 0));
                    break;
                case BallLaunch.right:
                    ball.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(75f + halfWidht, 0));
                    ballFilling.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(75f + halfWidht, 0));
                    break;
                case BallLaunch.bottom:
                    ball.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(0, 75f + halfWidht));
                    ballFilling.Move(beatTime, beatTime + 800, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(0, 75f + halfWidht));
                    break;
            }

        }
    }
}
