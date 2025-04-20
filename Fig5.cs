using OpenTK;
using OpenTK.Graphics;
using storyboard.scriptslibrary;
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
    public class Fig5 : StoryboardObjectGenerator
    {

        float ballSize = 0.1f;

        float travelDistance = 100f;
        double s = 80721;
        double d = 1300;

        float initialSineMovement = -75f + 20;

        double movement = 100f * 6f;
        double movementDuration = 1300 * 6f;

        public override void Generate()
        {

            var textlayer = GetLayer("text");
            var fLayer = GetLayer("fLayer");

            var topLeft = new Vector2(320 + 50 + 10, 157);
            var topRight = new Vector2(320 + 215 + 10, 157);
            var bottomLeft = new Vector2(320 + 50 + 10, 322);
            var bottomRight = new Vector2(320 + 215 + 10, 322);

            var figure = fLayer.CreateSprite("sb/figure/caption5.png", OsbOrigin.BottomLeft, new Vector2(320 - 30, 75));
            figure.Scale(79903, 0.23f);
            figure.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            figure.Fade(OsbEasing.OutSine, 89448, 89994, 1, 0);
            figure.Color(79903, new Color4(0, 0, 0, 0));

            figure.MoveX(OsbEasing.InSine, s, s + d, figure.PositionAt(s).X, figure.PositionAt(s).X + initialSineMovement);
            figure.MoveX(OsbEasing.None, s + d, s + d + movementDuration, figure.PositionAt(s + d).X, figure.PositionAt(s + d).X - movement);

            var dotBit = GetMapsetBitmap("sb/dots.png");
            var dots0 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, topLeft);
            dots0.ScaleVec(79903, new Vector2(146f / dotBit.Width));
            dots0.Color(79903, new Color4(89, 82, 76, 0));
            dots0.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            dots0.Fade(OsbEasing.InSine, 83448, 83857, 1, 0);

            var frame0 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, topLeft);
            frame0.ScaleVec(79903, new Vector2(380f / dotBit.Width));
            frame0.Color(79903, new Color4(0, 0, 0, 0));
            frame0.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            frame0.Fade(OsbEasing.InSine, 83448, 83857, 1, 0);

            var dots1 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, topRight);
            dots1.ScaleVec(79903, new Vector2(146f / dotBit.Width));
            dots1.Color(79903, new Color4(89, 82, 76, 0));
            dots1.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            dots1.Fade(OsbEasing.InSine, 85630, 86039, 1, 0);

            var frame1 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, topRight);
            frame1.ScaleVec(79903, new Vector2(380f / dotBit.Width));
            frame1.Color(79903, new Color4(0, 0, 0, 0));
            frame1.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            frame1.Fade(OsbEasing.InSine, 85630, 86039, 1, 0);

            var dots2 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, bottomLeft);
            dots2.ScaleVec(79903, new Vector2(146f / dotBit.Width));
            dots2.Color(79903, new Color4(89, 82, 76, 0));
            dots2.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            dots2.Fade(OsbEasing.InSine, 83448, 83857, 1, 0);

            var frame2 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, bottomLeft);
            frame2.ScaleVec(79903, new Vector2(380f / dotBit.Width));
            frame2.Color(79903, new Color4(0, 0, 0, 0));
            frame2.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            frame2.Fade(OsbEasing.InSine, 83448, 83857, 1, 0);

            var dots3 = fLayer.CreateSprite("sb/dots.png", OsbOrigin.Centre, bottomRight);
            dots3.ScaleVec(79903, new Vector2(146f / dotBit.Width));
            dots3.Color(79903, new Color4(89, 82, 76, 0));
            dots3.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            dots3.Fade(OsbEasing.InSine, 85630, 86039, 1, 0);

            var frame3 = fLayer.CreateSprite("sb/frame.png", OsbOrigin.Centre, bottomRight);
            frame3.ScaleVec(79903, new Vector2(380f / dotBit.Width));
            frame3.Color(79903, new Color4(0, 0, 0, 0));
            frame3.Fade(OsbEasing.InSine, 79903, 80721, 0, 1);
            frame3.Fade(OsbEasing.InSine, 85630, 86039, 1, 0);

            dots0.MoveX(OsbEasing.InSine, s, s + d, dots0.PositionAt(s).X, dots0.PositionAt(s).X + initialSineMovement);
            dots0.MoveX(OsbEasing.None, s + d, s + d + movementDuration, dots0.PositionAt(s + d).X, dots0.PositionAt(s + d).X - movement);
            frame0.MoveX(OsbEasing.InSine, s, s + d, frame0.PositionAt(s).X, frame0.PositionAt(s).X + initialSineMovement);
            frame0.MoveX(OsbEasing.None, s + d, s + d + movementDuration, frame0.PositionAt(s + d).X, frame0.PositionAt(s + d).X - movement);

            dots1.MoveX(OsbEasing.InSine, s, s + d, dots1.PositionAt(s).X, dots1.PositionAt(s).X + initialSineMovement);
            dots1.MoveX(OsbEasing.None, s + d, s + d + movementDuration, dots1.PositionAt(s + d).X, dots1.PositionAt(s + d).X - movement);
            frame1.MoveX(OsbEasing.InSine, s, s + d, frame1.PositionAt(s).X, frame1.PositionAt(s).X + initialSineMovement);
            frame1.MoveX(OsbEasing.None, s + d, s + d + movementDuration, frame1.PositionAt(s + d).X, frame1.PositionAt(s + d).X - movement);

            dots2.MoveX(OsbEasing.InSine, s, s + d, dots2.PositionAt(s).X, dots2.PositionAt(s).X + initialSineMovement);
            dots2.MoveX(OsbEasing.None, s + d, s + d + movementDuration, dots2.PositionAt(s + d).X, dots2.PositionAt(s + d).X - movement);
            frame2.MoveX(OsbEasing.InSine, s, s + d, frame2.PositionAt(s).X, frame2.PositionAt(s).X + initialSineMovement);
            frame2.MoveX(OsbEasing.None, s + d, s + d + movementDuration, frame2.PositionAt(s + d).X, frame2.PositionAt(s + d).X - movement);

            dots3.MoveX(OsbEasing.InSine, s, s + d, dots3.PositionAt(s).X, dots3.PositionAt(s).X + initialSineMovement);
            dots3.MoveX(OsbEasing.None, s + d, s + d + movementDuration, dots3.PositionAt(s + d).X, dots3.PositionAt(s + d).X - movement);
            frame3.MoveX(OsbEasing.InSine, s, s + d, frame3.PositionAt(s).X, frame3.PositionAt(s).X + initialSineMovement);
            frame3.MoveX(OsbEasing.None, s + d, s + d + movementDuration, frame3.PositionAt(s + d).X, frame3.PositionAt(s + d).X - movement);

            SpawnOutLines(topRight, bottomRight, 165, 80721 - 1000, 80721 + Beatmap.GetControlPointAt(80721).BeatDuration * 13);

            var start = 80721 + 550;
            int gap = (int)Beatmap.GetControlPointAt(start).BeatDuration * 4;
            start += gap;
            for (int i = 0; i < 13; i++)
            {
                SpawnOutLines(topRight, bottomRight, 165, start, start + Beatmap.GetControlPointAt(start).BeatDuration * 12);
                start += gap;
            }

            SpawnBlockProgression(topLeft, new Vector2(41, -41), 80176 + 200, BallLaunch.bottom, new BallLaunch[] { BallLaunch.right, BallLaunch.top }, new double[] { 81812, 82357 });
            SpawnBlockProgression(bottomLeft, new Vector2(-31, 41), 80176 + 200, BallLaunch.right, new BallLaunch[] { BallLaunch.bottom, BallLaunch.left }, new double[] { 82903, 83448 });
            SpawnBlockProgression(topRight, new Vector2(41, 41), 80176 + 200, BallLaunch.top, new BallLaunch[] { BallLaunch.right, BallLaunch.bottom }, new double[] { 83994, 84539 });
            SpawnBlockProgression(bottomRight, new Vector2(-31, -41), 80176 + 200, BallLaunch.right, new BallLaunch[] { BallLaunch.top, BallLaunch.left }, new double[] { 85085, 85630 });

            start = 80721 + 550;

            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(41, 41), 80176 + 200, BallLaunch.top, new BallLaunch[] { BallLaunch.right, BallLaunch.left }, new double[] { 86176, 86721 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(-31, 41), 80176 + 200, BallLaunch.right, new BallLaunch[] { BallLaunch.bottom, BallLaunch.left }, new double[] { 87266, 87812 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(41, 41), start, BallLaunch.top, new BallLaunch[] { BallLaunch.right, BallLaunch.bottom }, new double[] { 88357, 88903 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(-31, -41), start, BallLaunch.right, new BallLaunch[] { BallLaunch.top, BallLaunch.bottom }, new double[] { 89448, 89994 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.right, BallLaunch.top }, new double[] { 90539, 91085 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(-31, 41), start, BallLaunch.right, new BallLaunch[] { BallLaunch.bottom, BallLaunch.left, BallLaunch.bottom }, new double[] { 91630, 91903, 92176 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.top }, new double[] { 92721, 93266 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, 41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.bottom, BallLaunch.right }, new double[] { 93812, 94357 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, 41), start, BallLaunch.top, new BallLaunch[] { BallLaunch.left, BallLaunch.bottom }, new double[] { 94903, 95448 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, -41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.top, BallLaunch.right }, new double[] { 95994, 96539 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.top }, new double[] { 97085, 97630 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, 41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.bottom, BallLaunch.top }, new double[] { 98176, 98721 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.right }, new double[] { 99266, 99812 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, -41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.top, BallLaunch.right }, new double[] { 100357, 100903 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, 41), start, BallLaunch.top, new BallLaunch[] { BallLaunch.left, BallLaunch.bottom }, new double[] { 101448, 101994 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.right }, new double[] { 102539, 103085 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(31, 41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.bottom, BallLaunch.top }, new double[] { 103630, 104176 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.top }, new double[] { 104721, 105266 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(31, 41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.bottom, BallLaunch.right }, new double[] { 105812, 106357 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.right }, new double[] { 106903, 107448 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, 41), start, BallLaunch.top, new BallLaunch[] { BallLaunch.left, BallLaunch.bottom }, new double[] { 107994, 108403 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, -51), start, BallLaunch.left, new BallLaunch[] { BallLaunch.top, BallLaunch.right }, new double[] { 108948, 109630 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.top }, new double[] { 110176, 110721 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, 41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.bottom, BallLaunch.right }, new double[] { 111266, 111812 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, 41), start, BallLaunch.top, new BallLaunch[] { BallLaunch.left, BallLaunch.bottom }, new double[] { 112357, 112903 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, -41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.top, BallLaunch.right }, new double[] { 113448, 113994 });
            start += gap;
            SpawnBlockProgression(topRight + new Vector2(165, 0), new Vector2(-41, -41), start, BallLaunch.bottom, new BallLaunch[] { BallLaunch.left, BallLaunch.right }, new double[] { 114539, 115085 });
            SpawnBlockProgression(bottomRight + new Vector2(165, 0), new Vector2(31, 41), start, BallLaunch.left, new BallLaunch[] { BallLaunch.bottom, BallLaunch.right }, new double[] { 115630, 116176 });
            start += gap;
        }

        public void SpawnOutLines(Vector2 topRoot, Vector2 bottomRoot, float offset, double start, double end)
        {

            topRoot += new Vector2(offset, 0);
            bottomRoot += new Vector2(offset, 0);

            var dotBit = GetMapsetBitmap("sb/dots.png");
            var dots0 = GetLayer("fLayer").CreateSprite("sb/dots.png", OsbOrigin.Centre, topRoot);
            dots0.ScaleVec(start, new Vector2(146f / dotBit.Width));
            dots0.Color(start, new Color4(89, 82, 76, 0));
            dots0.Fade(start, 1);
            dots0.Fade(OsbEasing.InSine, end, end + 83857 - 83448, 1, 0);

            var frame0 = GetLayer("fLayer").CreateSprite("sb/frame.png", OsbOrigin.Centre, topRoot);
            frame0.ScaleVec(start, new Vector2(380f / dotBit.Width));
            frame0.Color(start, new Color4(0, 0, 0, 0));
            frame0.Fade(start, 1);
            frame0.Fade(OsbEasing.InSine, end, end + 83857 - 83448, 1, 0);

            var dots1 = GetLayer("fLayer").CreateSprite("sb/dots.png", OsbOrigin.Centre, bottomRoot);
            dots1.ScaleVec(start, new Vector2(146f / dotBit.Width));
            dots1.Color(start, new Color4(89, 82, 76, 0));
            dots1.Fade(start, 1);
            dots1.Fade(OsbEasing.InSine, end, end + 83857 - 83448, 1, 0);

            var frame1 = GetLayer("fLayer").CreateSprite("sb/frame.png", OsbOrigin.Centre, bottomRoot);
            frame1.ScaleVec(start, new Vector2(380f / dotBit.Width));
            frame1.Color(start, new Color4(0, 0, 0, 0));
            frame1.Fade(start, 1);
            frame1.Fade(OsbEasing.InSine, end, end + 83857 - 83448, 1, 0);

            var movement = travelDistance * 6f;
            var movementDuration = d * 6f;

            if (start == 80721 - 1000)
            {
                start += 1000;
                dots0.MoveX(OsbEasing.InSine, start, start + d, dots0.PositionAt(s).X, dots0.PositionAt(s).X + initialSineMovement);
                frame0.MoveX(OsbEasing.InSine, start, start + d, frame0.PositionAt(s).X, frame0.PositionAt(s).X + initialSineMovement);
                frame1.MoveX(OsbEasing.InSine, start, start + d, frame1.PositionAt(s).X, frame1.PositionAt(s).X + initialSineMovement);
                dots1.MoveX(OsbEasing.InSine, start, start + d, dots1.PositionAt(s).X, dots1.PositionAt(s).X + initialSineMovement);
            }
            else
            {
                start -= d;
            }
            
            dots0.MoveX(OsbEasing.None, start + d, start + d + movementDuration, dots0.PositionAt(s + d).X, dots0.PositionAt(s + d).X - movement);
            frame0.MoveX(OsbEasing.None, start + d, start + d + movementDuration, frame0.PositionAt(s + d).X, frame0.PositionAt(s + d).X - movement);
            frame1.MoveX(OsbEasing.None, start + d, start + d + movementDuration, frame1.PositionAt(s + d).X, frame1.PositionAt(s + d).X - movement);
            dots1.MoveX(OsbEasing.None, start + d, start + d + movementDuration, dots1.PositionAt(s + d).X, dots1.PositionAt(s + d).X - movement);

        }

        public void SpawnBlockProgression(Vector2 rootCord, Vector2 offset, double spawnTime, BallLaunch direction, BallLaunch[] bounces, double[] timings)
        {

            var localRoot = rootCord;
            localRoot += offset;

            var scale = ballSize;
            var ballBit = GetMapsetBitmap("sb/ball.png");
            var ballWidht = scale * ballBit.Width;
            var halfWidht = ballWidht / 2;

            var fadeInTime = 400f;
            var distancePerMs = 115f / 800f;

            var positions = new Vector2[4];
            var durations = new double[4];

            var start = timings[0];

            var dotBit = GetMapsetBitmap("sb/dots.png");
            var frame = GetLayer("flayer").CreateSprite("sb/frame.png", OsbOrigin.Centre, rootCord);
            frame.ScaleVec(OsbEasing.None, start - 1000, start, new Vector2(430f / dotBit.Width), new Vector2(380f / dotBit.Width));
            frame.Color(start, new Color4(95, 93, 92, 0));
            frame.ScaleVec(OsbEasing.OutCirc, start, start + 2000f, new Vector2(380f / dotBit.Width), new Vector2(430f / dotBit.Width));
            frame.Fade(OsbEasing.OutCirc, start, start + 1000f, 0.5f, 0);

            if (start < 87812)
            {
                frame.MoveX(OsbEasing.InSine, s, s + d, frame.PositionAt(s).X, frame.PositionAt(s).X + initialSineMovement);
                frame.MoveX(OsbEasing.None, s + d, s + d + movementDuration, frame.PositionAt(s + d).X, frame.PositionAt(s + d).X - movement);
            }
            else
            {
                frame.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, rootCord.X, rootCord.X - movement);
            }


            if (start - 1000 < 79903)
            {
                frame.Fade(start, 0);
                frame.Fade(OsbEasing.InSine, 79903 + 200, 79903 + 200 + 400, 0, 1);
            }
            else
            {
                frame.Fade(OsbEasing.OutSine, start - 1000, start, 0, 1f);
            }

            // Create ballBounce array with initial direction and all bounces
            var ballBounce = new BallLaunch[bounces.Length + 1];
            ballBounce[0] = direction;  // Add initial direction
            for (int i = 0; i < bounces.Length; i++)
            {
                ballBounce[i + 1] = bounces[i];  // Add all bounce directions
            }

            BallLaunch priodDirection = direction;

            for (int i = 0; i < bounces.Length; i++)
            {
                var hittime = timings[i];
                var hitDirection = bounces[i];
                var rot = -Math.PI / 4;

                switch (direction)
                {
                    case BallLaunch.top:
                        switch (hitDirection)
                        {
                            case BallLaunch.right:
                                break;
                            case BallLaunch.left:
                                rot = -rot;
                                break;
                            case BallLaunch.bottom:
                                rot = 0;
                                break;
                        }
                        break;
                    case BallLaunch.left:
                        switch (hitDirection)
                        {
                            case BallLaunch.top:
                                rot = -rot;
                                break;
                            case BallLaunch.bottom:
                                break;
                            case BallLaunch.right:
                                rot = Math.PI / 2;
                                break;
                        }
                        break;
                    case BallLaunch.right:
                        switch (hitDirection)
                        {
                            case BallLaunch.top:

                                break;
                            case BallLaunch.bottom:
                                rot = -rot;
                                break;
                            case BallLaunch.left:
                                rot = Math.PI / 2;
                                break;
                        }
                        break;
                    case BallLaunch.bottom:
                        switch (hitDirection)
                        {
                            case BallLaunch.left:
                                break;
                            case BallLaunch.right:
                                rot = -rot;
                                break;
                            case BallLaunch.top:
                                rot = 0;
                                break;
                        }
                        break;
                }

                var blockOffset = new Vector2(0, 0);

                if (i >= 1)
                {

                    if (priodDirection == BallLaunch.left && direction == BallLaunch.bottom && hitDirection == BallLaunch.left)
                    {
                        blockOffset.X -= ballWidht;
                    }
                    if (priodDirection == BallLaunch.left && direction == BallLaunch.top && hitDirection == BallLaunch.left)
                    {
                        blockOffset.X -= ballWidht;
                    }
                    if (priodDirection == BallLaunch.right && direction == BallLaunch.top && hitDirection == BallLaunch.right)
                    {
                        blockOffset.X += ballWidht;
                    }
                    if (priodDirection == BallLaunch.right && direction == BallLaunch.bottom && hitDirection == BallLaunch.right)
                    {
                        blockOffset.X += ballWidht;
                    }
                    if (priodDirection == BallLaunch.top && direction == BallLaunch.left && hitDirection == BallLaunch.top)
                    {
                        blockOffset.Y -= ballWidht;
                    }
                    if (priodDirection == BallLaunch.bottom && direction == BallLaunch.right && hitDirection == BallLaunch.bottom)
                    {
                        blockOffset.Y += ballWidht;
                    }
                    if (priodDirection == BallLaunch.top && direction == BallLaunch.right && hitDirection == BallLaunch.left)
                    {
                        blockOffset.Y -= halfWidht;
                    }
                    if (priodDirection == BallLaunch.right && direction == BallLaunch.top && hitDirection == BallLaunch.bottom)
                    {
                        blockOffset.X += halfWidht;
                    }
                    if (priodDirection == BallLaunch.bottom && direction == BallLaunch.left && hitDirection == BallLaunch.bottom)
                    {
                        blockOffset.Y += ballWidht;
                        blockOffset.X += halfWidht;
                    }
                    if (priodDirection == BallLaunch.left && direction == BallLaunch.bottom && hitDirection == BallLaunch.top)
                    {
                        blockOffset.X -= halfWidht;
                    }
                    if (priodDirection == BallLaunch.bottom && direction == BallLaunch.left && hitDirection == BallLaunch.right)
                    {
                        blockOffset.Y += halfWidht;
                    }
                }

                priodDirection = direction;
                direction = hitDirection;

                var controlPoint = Beatmap.GetControlPointAt((int)hittime);
                int noteType = ColorSnap(hittime, controlPoint.BeatDuration, controlPoint.Offset);

                var hitColor = new[] { new Color4(151, 78, 86, 255), new Color4(114, 107, 173, 255), new Color4(163, 222, 173, 255) };

                var blockOutLine = GetLayer("blocks").CreateSprite("sb/white.png", OsbOrigin.Centre, localRoot + blockOffset);
                var blockTop = GetLayer("blocks").CreateSprite("sb/white.png", OsbOrigin.Centre, localRoot + blockOffset);
                var blockHitOutline = GetLayer("blocks").CreateSprite("sb/white.png", OsbOrigin.Centre, localRoot + blockOffset);
                var blockHitType = GetLayer("blocks").CreateSprite("sb/white.png", OsbOrigin.Centre, localRoot + blockOffset);

                blockTop.ScaleVec(spawnTime, new Vector2(28f, 7f));
                blockTop.Rotate(spawnTime, rot);
                blockTop.Color(spawnTime, new Color4(95, 93, 92, 255));
                blockTop.Fade(OsbEasing.InSine, spawnTime, spawnTime + fadeInTime, 0, 1f);
                blockTop.Fade(OsbEasing.OutSine, hittime, hittime + fadeInTime, 1f, 0);

                blockOutLine.ScaleVec(spawnTime, new Vector2(30, 9));
                blockOutLine.Rotate(spawnTime, rot);
                blockOutLine.Color(spawnTime, new Color4(0, 0, 0, 255));
                blockOutLine.Fade(OsbEasing.InSine, spawnTime, spawnTime + fadeInTime, 0, 1f);
                blockOutLine.Fade(OsbEasing.OutSine, hittime, hittime + fadeInTime, 1f, 0);

                blockHitOutline.Scale(spawnTime, 6);
                blockHitOutline.Color(spawnTime, new Color4(0, 0, 0, 255));
                blockHitOutline.Fade(OsbEasing.InSine, spawnTime, spawnTime + fadeInTime, 0, 1f);
                blockHitOutline.Fade(OsbEasing.OutSine, hittime, hittime + fadeInTime, 1f, 0);

                blockHitType.Scale(17448, 3.8f);
                blockHitType.Color(17448, hitColor[noteType]);
                blockHitType.Fade(OsbEasing.InSine, spawnTime, spawnTime + fadeInTime, 0, 1f);
                blockHitType.Fade(OsbEasing.OutSine, hittime, hittime + fadeInTime, 1f, 0);

                if (spawnTime > 49085)
                {
                    blockTop.Fade(49085, 0);
                    blockOutLine.Fade(49085, 0);
                    blockHitOutline.Fade(49085, 0);
                    blockHitType.Fade(49085, 0);
                }

                var travelDistance = Vector2.Zero;
                var duration = (i + 1 < timings.Length) ?
                    (float)(timings[i + 1] - hittime) :
                    0f; // Use 300ms as default duration if we're at the end

                if (direction == BallLaunch.right)
                {
                    travelDistance = new Vector2(-distancePerMs * duration, 0);
                }
                else if (direction == BallLaunch.left)
                {
                    travelDistance = new Vector2(distancePerMs * duration, 0);
                }
                else if (direction == BallLaunch.top)
                {
                    travelDistance = new Vector2(0, distancePerMs * duration);
                }
                else if (direction == BallLaunch.bottom)
                {
                    travelDistance = new Vector2(0, -distancePerMs * duration);
                }

                if (start < 87812)
                {
                    blockTop.MoveX(OsbEasing.InSine, s, s + d, blockTop.PositionAt(s).X, blockTop.PositionAt(s).X + initialSineMovement);
                    blockTop.MoveX(OsbEasing.None, s + d, s + d + movementDuration, blockTop.PositionAt(s + d).X, blockTop.PositionAt(s + d).X - movement);
                    blockOutLine.MoveX(OsbEasing.InSine, s, s + d, blockTop.PositionAt(s).X, blockTop.PositionAt(s).X + initialSineMovement);
                    blockOutLine.MoveX(OsbEasing.None, s + d, s + d + movementDuration, blockTop.PositionAt(s + d).X, blockTop.PositionAt(s + d).X - movement);
                    blockHitOutline.MoveX(OsbEasing.InSine, s, s + d, blockTop.PositionAt(s).X, blockTop.PositionAt(s).X + initialSineMovement);
                    blockHitOutline.MoveX(OsbEasing.None, s + d, s + d + movementDuration, blockTop.PositionAt(s + d).X, blockTop.PositionAt(s + d).X - movement);
                    blockHitType.MoveX(OsbEasing.InSine, s, s + d, blockTop.PositionAt(s).X, blockTop.PositionAt(s).X + initialSineMovement);
                    blockHitType.MoveX(OsbEasing.None, s + d, s + d + movementDuration, blockTop.PositionAt(s + d).X, blockTop.PositionAt(s + d).X - movement);
                }
                else
                {
                    blockTop.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, blockTop.PositionAt(spawnTime).X, blockTop.PositionAt(spawnTime).X - movement);
                    blockOutLine.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, blockTop.PositionAt(spawnTime).X, blockTop.PositionAt(spawnTime).X - movement);
                    blockHitOutline.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, blockTop.PositionAt(spawnTime).X, blockTop.PositionAt(spawnTime).X - movement);
                    blockHitType.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, blockTop.PositionAt(spawnTime).X, blockTop.PositionAt(spawnTime).X - movement);
                }

                positions[i] = localRoot;
                localRoot += travelDistance;
                durations[i] = duration;
            }

            LaunchBall(positions, timings, ballBounce, spawnTime);

        }

        public void LaunchBall(Vector2[] positions, double[] timings, BallLaunch[] ballLaunches, double spawnTime)
        {

            var fadeInTime = 1000f;
            var fadeOutTime = 500f;
            var fadeInSpeed = 105f;
            var fadeOutSpeed = fadeInSpeed / fadeInTime * fadeOutTime;

            var scale = ballSize;
            var scaleFilling = 0.08f;
            var ballBit = GetMapsetBitmap("sb/ball.png");
            var ballWidht = scale * ballBit.Width;
            var halfWidht = ballWidht / 2;

            var starttime = timings[0] - fadeInTime;
            var finalDuration = timings[timings.Length - 1];
            Vector2 localRoot = positions[0];

            var initialOffset = new Vector2(0, 0);
            var LastOffset = new Vector2(0, 0);

            double helperRot = 0f;
            var arrowOffset = Vector2.Zero;

            var priodDirection = ballLaunches[0];
            var direction = ballLaunches[1];

            var offset = calcOffset(priodDirection, direction, direction, ballWidht);

            switch (ballLaunches[0])
            {
                case BallLaunch.left:
                    arrowOffset = new Vector2(fadeInSpeed - 25, 0);
                    initialOffset = new Vector2(fadeInSpeed, 0);
                    break;
                case BallLaunch.right:
                    helperRot = Math.PI;
                    arrowOffset = new Vector2(-fadeInSpeed + 25, 0);
                    initialOffset = new Vector2(-fadeInSpeed, 0);
                    break;
                case BallLaunch.top:
                    helperRot = Math.PI / 2;
                    arrowOffset = new Vector2(0, fadeInSpeed - 10);
                    initialOffset = new Vector2(0, fadeInSpeed);
                    break;
                case BallLaunch.bottom:
                    helperRot = -Math.PI / 2;
                    arrowOffset = new Vector2(0, -fadeInSpeed + 10);
                    initialOffset = new Vector2(0, -fadeInSpeed);
                    break;
            }

            switch (ballLaunches[ballLaunches.Length - 1])
            {
                case BallLaunch.left:
                    LastOffset = new Vector2(fadeOutSpeed, 0);
                    break;
                case BallLaunch.right:
                    LastOffset = new Vector2(-fadeOutSpeed, 0);
                    break;
                case BallLaunch.top:
                    LastOffset = new Vector2(0, fadeOutSpeed);
                    break;
                case BallLaunch.bottom:
                    LastOffset = new Vector2(0, -fadeOutSpeed);
                    break;
            }
            if (starttime > 79903)
            {
                var helper = GetLayer("flayer").CreateSprite("sb/helper.png", OsbOrigin.Centre, localRoot - arrowOffset - offset);
                helper.Scale(spawnTime, 0.09f);
                helper.Color(spawnTime, new Color4(0, 0, 0, 0));
                helper.Rotate(spawnTime, helperRot);
                helper.Fade(OsbEasing.InSine, spawnTime, spawnTime + fadeInTime, 0, 0.65f);
                helper.Fade(OsbEasing.OutSine, starttime, starttime + fadeInTime, .65f, 0);

                if (spawnTime < s + d)
                {
                    helper.MoveX(OsbEasing.InSine, s, s + d, helper.PositionAt(s).X, helper.PositionAt(s).X + initialSineMovement);
                    helper.MoveX(OsbEasing.None, s + d, s + d + movementDuration, helper.PositionAt(s + d).X, helper.PositionAt(s + d).X - movement);
                }
                else
                {
                    helper.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, helper.PositionAt(spawnTime).X, helper.PositionAt(spawnTime).X - movement);
                }
            }

            var ball = new RelativeSprite(GetLayer("ball"), "sb/ball.png", OsbOrigin.Centre, localRoot - initialOffset - offset);
            var ballFilling = new RelativeSprite(GetLayer("ball"), "sb/ball.png", OsbOrigin.Centre, localRoot - initialOffset - offset);

            ball.ScaleVec(starttime, new Vector2(scale, scale));
            ballFilling.ScaleVec(starttime, new Vector2(scaleFilling, scaleFilling));

            ball.Color(starttime, new Color4(0, 0, 0, 0));

            if (starttime < 79903)
            {
                ball.Fade(starttime, 0);
                ballFilling.Fade(starttime, 0);
                ball.Fade(OsbEasing.InSine, 79903 + 200, 79903 + 200 + 400, 0, 1);
                ballFilling.Fade(OsbEasing.InSine, 79903 + 200, 79903 + 200 + 400, 0, 1);
            }
            else
            {
                ball.Fade(OsbEasing.InSine, starttime, starttime + 200, 0, 1);

                ballFilling.Fade(OsbEasing.InSine, starttime, starttime + 200, 0, 1);
            }

            ball.Fade(OsbEasing.OutSine, finalDuration, finalDuration + 500, 1, 0);
            ballFilling.Fade(OsbEasing.OutSine, finalDuration, finalDuration + 500, 1, 0);
            ballFilling.Color(starttime, new Color4(95, 93, 92, 0));


            for (int i = -1; i < timings.Length; i++)
            {
                if (i == -1)
                {
                    // Initial spawn movement
                    ball.Move(starttime, timings[0], initialOffset);
                    ballFilling.Move(starttime, timings[0], initialOffset);
                }
                else if (i < timings.Length - 1)
                {

                    var hitDirection = ballLaunches[i + 2];

                    offset = calcOffset(priodDirection, direction, hitDirection, ballWidht);

                    priodDirection = direction;
                    direction = hitDirection;

                    // Calculate position adjustments based on directions
                    var currentPos = positions[i];
                    var nextPos = positions[i + 1];

                    ball.Move(timings[i], timings[i + 1], nextPos - currentPos + offset);
                    ballFilling.Move(timings[i], timings[i + 1], nextPos - currentPos + offset);
                }
                else if (i == timings.Length - 1)
                {
                    // Final movement
                    ball.Move(timings[i], timings[i] + 500, LastOffset);
                    ballFilling.Move(timings[i], timings[i] + 500, LastOffset);
                }
            }

            if (spawnTime < s + d)
            {
                ball.MoveX(OsbEasing.InSine, s, s + d, initialSineMovement);
                ball.MoveX(OsbEasing.None, s + d, s + d + movementDuration, -movement);

                ballFilling.MoveX(OsbEasing.InSine, s, s + d, initialSineMovement);
                ballFilling.MoveX(OsbEasing.None, s + d, s + d + movementDuration, -movement);
            }
            else
            {
                ball.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, -movement);

                ballFilling.MoveX(OsbEasing.None, spawnTime, spawnTime + movementDuration, -movement);
            }

            ball.WriteToSprite(starttime, finalDuration + 500, 1000 / 60);
            ballFilling.WriteToSprite(starttime, finalDuration + 500, 1000 / 60);
        }

        public int ColorSnap(double timing, double beatDuration, double offset)
        {
            int cycle = (int)Math.Floor((timing - offset) / beatDuration);

            int adjustedTime = (int)Math.Round(timing - offset - (cycle * beatDuration));

            int noteType = 0;

            if (IsCloseTo(adjustedTime, beatDuration, 4))  // 1/3 rhythms
            {
                noteType = 2;  // Whole tick
            }
            if (IsCloseTo(adjustedTime, beatDuration, 2))  // 1/3 rhythms
            {
                noteType = 1;  // Whole tick
            }
            if (IsCloseTo(adjustedTime, beatDuration, 1))  // 1/3 rhythms
            {
                noteType = 0;  // Whole tick
            }
            return noteType;
        }

        public Vector2 calcOffset(BallLaunch priorDirection, BallLaunch direction, BallLaunch hitDirection, double width)
        {
            var ballWidht = (float)width;
            var halfWidht = ballWidht / 2f;
            Vector2 offset = new Vector2(0, 0);

            Log($"Prior: {priorDirection}, Direction: {direction}, HitDirection: {hitDirection}");

            // Left as prior direction
            if (priorDirection == BallLaunch.left)
            {
                if (direction == BallLaunch.bottom && hitDirection == BallLaunch.left)
                {
                    offset.Y += ballWidht;
                }
                if (direction == BallLaunch.bottom && hitDirection == BallLaunch.bottom)
                {
                    offset.X += halfWidht;
                    offset.Y += halfWidht;
                }
                if (direction == BallLaunch.bottom && hitDirection == BallLaunch.right)
                {
                    offset.Y += ballWidht;
                }
                if (direction == BallLaunch.bottom && hitDirection == BallLaunch.top)
                {
                    offset.Y += ballWidht;
                }
                else if (direction == BallLaunch.top && hitDirection == BallLaunch.left)
                {
                    offset.Y -= ballWidht;
                }
                else if (direction == BallLaunch.top && hitDirection == BallLaunch.top)
                {
                    offset.X += halfWidht;
                    offset.Y -= halfWidht;
                }
                else if (direction == BallLaunch.top && hitDirection == BallLaunch.right)
                {
                    offset.Y -= ballWidht;
                }
            }
            // Right as prior direction
            else if (priorDirection == BallLaunch.right)
            {
                if (direction == BallLaunch.top && hitDirection == BallLaunch.right)
                {
                    offset.Y -= ballWidht;
                }
                if (direction == BallLaunch.top && hitDirection == BallLaunch.top)
                {
                    offset.X -= halfWidht;
                    offset.Y -= halfWidht;
                }
                if (direction == BallLaunch.top && hitDirection == BallLaunch.left)
                {
                    offset.Y -= ballWidht;
                }
                if (direction == BallLaunch.top && hitDirection == BallLaunch.bottom)
                {
                    offset.Y -= ballWidht;
                }
                else if (direction == BallLaunch.bottom && hitDirection == BallLaunch.bottom)
                {
                    offset.X -= halfWidht;
                    offset.Y += halfWidht;
                }
                else if (direction == BallLaunch.bottom && hitDirection == BallLaunch.left)
                {
                    offset.Y += ballWidht;
                }
            }
            // Top as prior direction
            else if (priorDirection == BallLaunch.top)
            {
                if (direction == BallLaunch.left && hitDirection == BallLaunch.left)
                {
                    offset.X -= halfWidht;
                    offset.Y += halfWidht;
                }
                if (direction == BallLaunch.left && hitDirection == BallLaunch.top)
                {
                    offset.X -= ballWidht;
                }
                if (direction == BallLaunch.left && hitDirection == BallLaunch.bottom)
                {
                    offset.X -= ballWidht;
                }
                if (direction == BallLaunch.right && hitDirection == BallLaunch.right)
                {
                    offset.X += halfWidht;
                    offset.Y += halfWidht;
                }
                if (direction == BallLaunch.right && hitDirection == BallLaunch.bottom)
                {
                    //offset.X += halfWidht;
                }
                if (direction == BallLaunch.right && hitDirection == BallLaunch.bottom)
                {
                    offset.X += ballWidht;
                }
                if (direction == BallLaunch.right && hitDirection == BallLaunch.left)
                {
                    offset.X += ballWidht;
                }
            }
            // Bottom as prior direction
            else if (priorDirection == BallLaunch.bottom)
            {
                if (direction == BallLaunch.right && hitDirection == BallLaunch.bottom)
                {
                    offset.X += ballWidht;
                }
                if (direction == BallLaunch.left && hitDirection == BallLaunch.bottom)
                {
                    offset.X -= halfWidht;
                }
                if (direction == BallLaunch.left && hitDirection == BallLaunch.left)
                {
                    offset.X -= halfWidht;
                    offset.Y -= halfWidht;
                }
                if (direction == BallLaunch.left && hitDirection == BallLaunch.top)
                {
                    offset.X -= ballWidht;
                }
                if (direction == BallLaunch.left && hitDirection == BallLaunch.right)
                {
                    offset.X -= ballWidht;
                }
                if (direction == BallLaunch.right && hitDirection == BallLaunch.top)
                {
                    offset.X += ballWidht;
                }
                if (direction == BallLaunch.right && hitDirection == BallLaunch.right)
                {
                    offset.X += halfWidht;
                    offset.Y -= halfWidht;
                }
            }

            return offset;
        }

        bool IsCloseTo(int adjusted, double beatDuration, int divisions, int margin = 2)
        {
            double baseTick = beatDuration / divisions;
            for (int multiplier = 1; multiplier <= divisions; multiplier++)
            {
                if (Math.Abs(adjusted - (baseTick * multiplier)) <= margin)
                    return true;
            }
            return false;
        }
    }
}
