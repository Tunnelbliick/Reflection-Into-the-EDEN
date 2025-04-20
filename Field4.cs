using OpenTK;
using OpenTK.Graphics;
using StorybrewCommon.Animations;
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

    public class Field4 : StoryboardObjectGenerator
    {

        private static readonly object lockObject = new object();
        public override void Generate()
        {

            var receptors = GetLayer("r");
            var notes = GetLayer("n");

            // General values
            var starttime = 109085; // the starttime where the playfield is initialized
            var endtime = 126539; // the endtime where the playfield is nolonger beeing rendered
            var duration = endtime - starttime; // the length the playfield is kept alive

            // Playfield Scale
            var width = 250f; // widht of the playfield / invert to flip
            var height = 350f; // height of the playfield / invert to flip -600 = downscroll | 600 = upscropll
            var receptorWallOffset = 80f; // how big the boundary box for the receptor is 50 means it will be pushed away 50 units from the wall

            // Note initilization Values
            var sliderAccuracy = 30; // The Segment length for sliderbodies since they are rendered in slices 30 is default
            var isColored = false; // This property is used if you want to color the notes by urself for effects. It does not swap if the snap coloring is used.

            // Drawinstance Values
            var updatesPerSecond = 50; // The amount of steps the rendring engine does to render out note and receptor positions
            var scrollSpeed = 1800f; // The speed at which the Notes scroll
            var fadeTime = 400f; // The time notes will fade in

            Playfield field = new Playfield();
            field.initilizePlayField(receptors, notes, starttime, 119994, width, height, receptorWallOffset, Beatmap.OverallDifficulty);
            field.noteEnd = 118494;
            field.initializeNotes(Beatmap.HitObjects.ToList(), Beatmap.GetTimingPointAt(starttime).Bpm, Beatmap.GetTimingPointAt(starttime).Offset, isColored, sliderAccuracy);

            Playfield field2 = new Playfield();
            field2.initilizePlayField(receptors, notes, 119994, endtime, width, height, receptorWallOffset, Beatmap.OverallDifficulty);
            field2.noteStart = 122994;
            field2.initializeNotes(Beatmap.HitObjects.ToList(), Beatmap.GetTimingPointAt(starttime).Bpm, Beatmap.GetTimingPointAt(starttime).Offset, isColored, sliderAccuracy);

            // Playfield field2 = new Playfield();
            // field2.initilizePlayField(receptors, notes, starttime, endtime, width, height, receptorWallOffset, Beatmap.OverallDifficulty);
            // field2.initializeNotes(Beatmap.HitObjects.ToList(), Beatmap.GetTimingPointAt(starttime).Bpm, Beatmap.GetTimingPointAt(starttime).Offset, isColored, sliderAccuracy);

            field.Scale(OsbEasing.None, starttime + 1, starttime + 1, new Vector2(0.4f));
            field2.Scale(OsbEasing.None, 119994 + 1, 119994 + 1, new Vector2(0.4f));
            field.moveFieldX(OsbEasing.None, starttime + 10, starttime + 10, 415);

            // Smooth transition sequence
            field.moveFieldX(OsbEasing.None, 111812, 116721, -370); // Changed to InOutSine for smooth start/end
            field.moveFieldX(OsbEasing.OutSine, 116721, 117812, -(415 - 370)); // Changed to OutQuart for natural deceleration

            field2.columns[ColumnType.one].receptor.renderedSprite.Fade(OsbEasing.InCubic, 124085, 125448, 1, 0);
            field2.columns[ColumnType.two].receptor.renderedSprite.Fade(OsbEasing.InCubic, 124085, 125448, 1, 0);
            field2.columns[ColumnType.three].receptor.renderedSprite.Fade(OsbEasing.InCubic, 124085, 125448, 1, 0);
            field2.columns[ColumnType.four].receptor.renderedSprite.Fade(OsbEasing.InCubic, 124085, 125448, 1, 0);

            // field2.Scale(OsbEasing.None, starttime + 1, starttime + 1, new Vector2(0.4f));
            // field2.moveFieldX(OsbEasing.None, starttime + 10, starttime + 10, 410);

            //field2.moveFieldX(OsbEasing.InOutSine, 49085, 54539, -240);

            // field2.moveFieldX(OsbEasing.InOutSine, 58357, 62721, 120);

            var local = 124085;
            var end = 125994;
            while (local <= end)
            {
                var progress = ((float)(local - 124085) / (float)(end - 124085));
                progress = (float)OsbEasing.OutSine.Ease(progress);
                field2.fadeAt(local, 0.9f - progress);  // Remove the 1 - progress to make it fade to 0
                //field2.fadeAt(local, 0.9f - progress); // Remove the 1 - progress to make it fade to 0
                local += 50;
            }

            DrawInstance draw = new DrawInstance(field, starttime + 50, scrollSpeed, updatesPerSecond, OsbEasing.None, true, fadeTime, fadeTime);
            draw.setReceptorMovementPrecision(0.1f);
            draw.drawViaEquation(119994 - starttime + 10, NoteFunction, true);

            DrawInstance draw2 = new DrawInstance(field2, 119994 + 10, scrollSpeed, updatesPerSecond, OsbEasing.None, true, fadeTime, fadeTime);
            draw2.setReceptorMovementPrecision(0.1f);
            draw2.drawViaEquation(endtime - 119994, NoteFunction, true);

            // DrawInstance draw2 = new DrawInstance(field2, starttime + 50, scrollSpeed, updatesPerSecond, OsbEasing.None, true, fadeTime, fadeTime);
            // draw2.drawViaEquation(duration - 10, NoteFunction, true);
        }

        // NoteFunction is used to manipulate the pathway and a bunch of other things the note should do on their way to the receptor
        // Please be warry that this is beeing run async so you need to keep thread safety in mind when working on complex Functions.
        // You can use the progress to determin how far the note is in its cycle 0 = just start | 1 = ontop of receptor / finished
        // Special flags for hold bodies exist
        public Vector2 NoteFunction(EquationParameters p)
        {

            return p.position;
        }
    }
}
