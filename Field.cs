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
    public class Field : StoryboardObjectGenerator
    {
        // Generate function in a storybrew script
        public override void Generate()
        {

            var receptors = GetLayer("r");
            var notes = GetLayer("n");

            // General values
            var starttime = 0; // the starttime where the playfield is initialized
            var endtime = 40000; // the endtime where the playfield is nolonger beeing rendered
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
            var fadeTime = 300f; // The time notes will fade in

            Playfield field = new Playfield();
            field.initilizePlayField(receptors, notes, starttime, endtime, width, height, receptorWallOffset, Beatmap.OverallDifficulty);
            field.noteEnd = 35094;
            field.initializeNotes(Beatmap.HitObjects.ToList(), Beatmap.GetTimingPointAt(starttime).Bpm, Beatmap.GetTimingPointAt(starttime).Offset, isColored, sliderAccuracy);

            field.Scale(OsbEasing.None, 1, 1, new Vector2(0.4f));

            field.columns[ColumnType.one].receptor.renderedSprite.Fade(5, 0);
            field.columns[ColumnType.two].receptor.renderedSprite.Fade(5, 0);
            field.columns[ColumnType.three].receptor.renderedSprite.Fade(5, 0);
            field.columns[ColumnType.four].receptor.renderedSprite.Fade(5, 0);

            field.columns[ColumnType.one].receptor.renderedSprite.Fade(10, 0);
            field.columns[ColumnType.two].receptor.renderedSprite.Fade(10, 0);
            field.columns[ColumnType.three].receptor.renderedSprite.Fade(10, 0);
            field.columns[ColumnType.four].receptor.renderedSprite.Fade(10, 0);

            var d = (17448 - 11448) / 4;
            var s = 11448;

            field.columns[ColumnType.one].receptor.renderedSprite.Fade(OsbEasing.InSine, s, s + d, 0, 1);
            s += d;
            field.columns[ColumnType.four].receptor.renderedSprite.Fade(OsbEasing.InSine, s, s + d, 0, 1);
            s += d;
            field.columns[ColumnType.two].receptor.renderedSprite.Fade(OsbEasing.InSine, s, s + d, 0, 1);
            s += d;
            field.columns[ColumnType.three].receptor.renderedSprite.Fade(OsbEasing.InSine, s, s + d, 0, 1);

            var local = Beatmap.GetControlPointAt(2000).Offset;
            var BeatDuration = Beatmap.GetControlPointAt(2000).BeatDuration;
            while (local < 36005)
            {
                field.Scale(OsbEasing.None, local, local, new Vector2(0.45f), true);
                field.Scale(OsbEasing.OutCirc, local, local + 500, new Vector2(0.4f), true);
                local += BeatDuration;
                field.Scale(OsbEasing.None, local, local, new Vector2(0.55f), true);
                field.Scale(OsbEasing.OutCirc, local, local + 500, new Vector2(0.4f), true);
                local += BeatDuration;
            }

            field.MoveColumnRelativeX(OsbEasing.OutSine, 10903, 19630, -175, ColumnType.one);
            field.MoveColumnRelativeX(OsbEasing.OutSine, 10903, 19630, -175, ColumnType.two);
            field.MoveColumnRelativeX(OsbEasing.OutSine, 10903, 19630, 175, ColumnType.three);
            field.MoveColumnRelativeX(OsbEasing.OutSine, 10903, 19630, 175, ColumnType.four);


            field.fadeAt(local, 0);

            field.columns[ColumnType.one].receptor.renderedSprite.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);
            field.columns[ColumnType.two].receptor.renderedSprite.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);
            field.columns[ColumnType.three].receptor.renderedSprite.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);
            field.columns[ColumnType.four].receptor.renderedSprite.Fade(OsbEasing.OutSine, 34903, 35994, 1f, 0);

            DrawInstance draw = new DrawInstance(field, 5, scrollSpeed, updatesPerSecond, OsbEasing.None, true, fadeTime, fadeTime);
            draw.drawViaEquation(duration - 10, NoteFunction, true);
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
