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
    public class Fig2 : StoryboardObjectGenerator
    {
        public override void Generate()
        {
            var textlayer = GetLayer("text");
            var fLayer = GetLayer("fLayer");

            var topLeft = new Vector2(320 - 85, 150);
            var topRight = new Vector2(320 + 85, 150);
            var bottomLeft = new Vector2(320 - 85, 320);
            var bottomRight = new Vector2(320 + 85, 320);

            var dots = GetLayer("back").CreateSprite("sb/dots_falloff.png");
            dots.Scale(35994, 0.175);
            dots.Color(35994, new Color4(89, 82, 76, 255));
            dots.Fade(OsbEasing.InSine, 35994, 37085, 0, 1);
            dots.Fade(OsbEasing.OutSine, 37085, 37903, 1, 0);

            dots.Fade(OsbEasing.InSine, 38175, 39266, 0, 1f);
            dots.Fade(OsbEasing.OutSine, 39266, 40357, 1f, 0);

            dots.Fade(OsbEasing.InSine, 40357, 41448, 0, 1f);
            dots.Fade(OsbEasing.OutSine, 41448, 42266, 1f, 0);

            dots.Fade(OsbEasing.InSine, 42539, 43630, 0, 1f);
            dots.Fade(OsbEasing.OutSine, 43630, 44721, 1f, 0);

            var figure = textlayer.CreateSprite("sb/figure/caption2.png", OsbOrigin.Centre, new Vector2(320, 450));
            figure.Scale(37085, 0.25);
            figure.Fade(OsbEasing.InSine, 35994, 37085, 0, 1);
            figure.Fade(OsbEasing.OutSine, 43630, 44721, 1f, 0);
            figure.Color(37085, new Color4(0, 0, 0, 0));

            var blockOutLine0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 240));
            var blockTop0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 240));
            var blockHitOutline0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 240));
            var blockHitType0 = fLayer.CreateSprite("sb/white.png", OsbOrigin.Centre, new Vector2(320, 240));

            blockTop0.ScaleVec(35994, new Vector2(80f, 13f));
            blockTop0.Rotate(35994, Math.PI / 4);
            blockTop0.Color(35994, new Color4(95, 93, 92, 255));
            blockTop0.Fade(OsbEasing.InSine, 35994, 37085, 0, 1f);
            blockTop0.Fade(OsbEasing.OutSine, 37085, 37903, 1f, 0);

            blockOutLine0.ScaleVec(35994, new Vector2(84f, 17f));
            blockOutLine0.Rotate(35994, Math.PI / 4);
            blockOutLine0.Color(35994, new Color4(0, 0, 0, 255));
            blockOutLine0.Fade(OsbEasing.InSine, 35994, 37085, 0, 1f);
            blockOutLine0.Fade(OsbEasing.OutSine, 37085, 37903, 1f, 0);

            blockHitOutline0.Scale(35994, 12);
            blockHitOutline0.Color(35994, new Color4(0, 0, 0, 255));
            blockHitOutline0.Fade(OsbEasing.InSine, 35994, 37085, 0, 1f);
            blockHitOutline0.Fade(OsbEasing.OutSine, 37085, 37903, 1f, 0);

            blockHitType0.Scale(35994, 8.5f);
            blockHitType0.Color(35994, new Color4(255, 0, 47, 255));
            blockHitType0.Fade(OsbEasing.InSine, 35994, 37085, 0, 1f);
            blockHitType0.Fade(OsbEasing.OutSine, 37085, 37903, 1f, 0);

            blockTop0.Rotate(38175, -Math.PI / 4);
            blockTop0.Fade(OsbEasing.InSine, 38175, 39266, 0, 1f);
            blockTop0.Fade(OsbEasing.OutSine, 39266, 40357, 1f, 0);
            blockOutLine0.Rotate(38175, -Math.PI / 4);
            blockOutLine0.Fade(OsbEasing.InSine, 38175, 39266, 0, 1f);
            blockOutLine0.Fade(OsbEasing.OutSine, 39266, 40357, 1f, 0);
            blockHitOutline0.Fade(OsbEasing.InSine, 38175, 39266, 0, 1f);
            blockHitOutline0.Fade(OsbEasing.OutSine, 39266, 40357, 1f, 0);
            blockHitType0.Fade(OsbEasing.InSine, 38175, 39266, 0, 1f);
            blockHitType0.Fade(OsbEasing.OutSine, 39266, 40357, 1f, 0);


            blockTop0.Rotate(40357, Math.PI / 4);
            blockTop0.Fade(OsbEasing.InSine, 40357, 41448, 0, 1f);
            blockTop0.Fade(OsbEasing.OutSine, 41448, 42266, 1f, 0);
            blockOutLine0.Rotate(40357, Math.PI / 4);
            blockOutLine0.Fade(OsbEasing.InSine, 40357, 41448, 0, 1f);
            blockOutLine0.Fade(OsbEasing.OutSine, 41448, 42266, 1f, 0);
            blockHitOutline0.Fade(OsbEasing.InSine, 40357, 41448, 0, 1f);
            blockHitOutline0.Fade(OsbEasing.OutSine, 41448, 42266, 1f, 0);
            blockHitType0.Fade(OsbEasing.InSine, 40357, 41448, 0, 1f);
            blockHitType0.Fade(OsbEasing.OutSine, 41448, 42266, 1f, 0);

            blockTop0.Rotate(42539, -Math.PI / 4);
            blockTop0.Fade(OsbEasing.InSine, 42539, 43630, 0, 1f);
            blockTop0.Fade(OsbEasing.OutSine, 43630, 44721, 1f, 0);
            blockOutLine0.Rotate(42539, -Math.PI / 4);
            blockOutLine0.Fade(OsbEasing.InSine, 42539, 43630, 0, 1f);
            blockOutLine0.Fade(OsbEasing.OutSine, 43630, 44721, 1f, 0);
            blockHitOutline0.Fade(OsbEasing.InSine, 42539, 43630, 0, 1f);
            blockHitOutline0.Fade(OsbEasing.OutSine, 43630, 44721, 1f, 0);
            blockHitType0.Fade(OsbEasing.InSine, 42539, 43630, 0, 1f);
            blockHitType0.Fade(OsbEasing.OutSine, 43630, 44721, 1f, 0);

            LaunchBall(BallLaunch.top, BallLaunch.right, new Vector2(320, 240), 37085);
            LaunchBall(BallLaunch.right, BallLaunch.bottom, new Vector2(320, 240), 39266);
            LaunchBall(BallLaunch.right, BallLaunch.top, new Vector2(320, 240), 41448);
            LaunchBall(BallLaunch.top, BallLaunch.left, new Vector2(320, 240), 43630);


        }

        public void LaunchBall(BallLaunch launchOrigin, BallLaunch direction, Vector2 rootCord, double beatTime)
        {
            var scale = 0.15f;
            var scaleFilling = 0.13f;
            var ballBit = GetMapsetBitmap("sb/ball.png");
            var ballWidht = scale * ballBit.Width;
            var halfWidht = ballWidht / 2;

            var distance = 150f;

            var outline = GetLayer("back").CreateSprite("sb/outline.png");
            var outline2 = GetLayer("back").CreateSprite("sb/outline.png");
            var fill = GetLayer("back").CreateSprite("sb/fill.png");
            outline.Scale(beatTime - (43630 - 42539), 0.7f);
            outline.Color(beatTime - (43630 - 42539), new Color4(95, 93, 92, 0));
            outline.Fade(OsbEasing.InSine, beatTime - (43630 - 42539), beatTime, 0, 0.5f);
            outline.Fade(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), 0.5f, 0);
            outline.Scale(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), 0.7f, 0.8f);

            outline2.Scale(beatTime - (43630 - 42539), 0.7f);
            outline2.Color(beatTime - (43630 - 42539), new Color4(95, 93, 92, 0));
            outline2.Fade(OsbEasing.InSine, beatTime - (43630 - 42539), beatTime, 0, 0.4f);
            outline2.Fade(beatTime, 0);
            outline2.Scale(beatTime - (43630 - 42539), beatTime, 1.5f, 0.7f);

            fill.Scale(OsbEasing.InSine, beatTime - (43630 - 42539), beatTime, .2f, 0.7f);
            fill.Color(beatTime - (43630 - 42539), new Color4(95, 93, 92, 0));
            fill.Fade(OsbEasing.InSine, beatTime - (43630 - 42539), beatTime, 0, 0.5f);
            fill.Fade(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), 0.5f, 0);
            fill.Scale(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), 0.7f, 0.8f);

            var ball = GetLayer("fLayer").CreateSprite("sb/ball.png", OsbOrigin.Centre, rootCord);
            var ballFilling = GetLayer("fLayer").CreateSprite("sb/ball.png", OsbOrigin.Centre, rootCord);


            switch (launchOrigin)
            {
                case BallLaunch.top:
                    rootCord.Y -= distance + halfWidht;
                    // ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(scale, 0), new Vector2(scale, scale));
                    // ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(scaleFilling, 0), new Vector2(scaleFilling, scaleFilling));
                    break;
                case BallLaunch.left:
                    rootCord.X -= distance + halfWidht;
                    // ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scale), new Vector2(scale, scale));
                    // ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scaleFilling), new Vector2(scaleFilling, scaleFilling));
                    break;
                case BallLaunch.right:
                    rootCord.X += distance + halfWidht;
                    //  ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scale), new Vector2(scale, scale));
                    //  ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scaleFilling), new Vector2(scaleFilling, scaleFilling));
                    break;
                case BallLaunch.bottom:
                    rootCord.Y += distance + halfWidht;
                    // ball.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(scale, 0), new Vector2(scale, scale));
                    // ballFilling.ScaleVec(beatTime - 780, beatTime - 720, new Vector2(0, scaleFilling), new Vector2(scaleFilling, scaleFilling));
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
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y + distance);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y + distance);
                    break;
                case BallLaunch.left:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X + distance, rootCord.Y);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X + distance, rootCord.Y);
                    break;
                case BallLaunch.right:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X - distance, rootCord.Y);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X - distance, rootCord.Y);
                    break;
                case BallLaunch.bottom:
                    ball.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y - distance);
                    ballFilling.Move(beatTime - 1000, beatTime, rootCord.X, rootCord.Y, rootCord.X, rootCord.Y - distance);
                    break;
            }

            switch (direction)
            {
                case BallLaunch.top:
                    outline.Rotate(beatTime - (43630 - 42539), -Math.PI);
                    outline2.Rotate(beatTime - (43630 - 42539), -Math.PI);
                    fill.Rotate(beatTime - (43630 - 42539), -Math.PI);
                    outline.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), -Math.PI, -Math.PI + 0.025f);
                    fill.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), -Math.PI, -Math.PI + 0.025f);
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(0, distance + halfWidht));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(0, distance + halfWidht));
                    break;
                case BallLaunch.left:
                    outline.Rotate(beatTime - (43630 - 42539), Math.PI / 2);
                    outline2.Rotate(beatTime - (43630 - 42539), Math.PI / 2);
                    fill.Rotate(beatTime - (43630 - 42539), Math.PI / 2);
                    outline.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), Math.PI / 2, Math.PI / 2 + 0.025f);
                    fill.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), Math.PI / 2, Math.PI / 2 + 0.025f);
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(distance + halfWidht, 0));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) - new Vector2(distance + halfWidht, 0));
                    break;
                case BallLaunch.right:
                    outline.Rotate(beatTime - (43630 - 42539), -Math.PI / 2);
                    outline2.Rotate(beatTime - (43630 - 42539), -Math.PI / 2);
                    fill.Rotate(beatTime - (43630 - 42539), -Math.PI / 2);
                    outline.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), -Math.PI / 2, -Math.PI / 2 + 0.025f);
                    fill.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), -Math.PI / 2, -Math.PI / 2 + 0.025f);
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(distance + halfWidht, 0));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(distance + halfWidht, 0));
                    break;
                case BallLaunch.bottom:
                    outline.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), 0, 0.025f);
                    fill.Rotate(OsbEasing.OutSine, beatTime, beatTime + (43630 - 42539), 0, 0.025f);
                    ball.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(0, distance + halfWidht));
                    ballFilling.Move(beatTime, beatTime + 1000, ball.PositionAt(beatTime), (Vector2)ball.PositionAt(beatTime) + new Vector2(0, distance + halfWidht));
                    break;
            }

        }
    }
}
