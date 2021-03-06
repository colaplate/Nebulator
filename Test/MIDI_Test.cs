using System;
using System.Collections.Generic;
using System.Windows.Forms;
using NBagOfTricks.PNUT;
using Nebulator.Common;
using Nebulator.Device;
using Nebulator.Midi;

namespace Nebulator.Test
{
    // Midi utils stuff.
    public class MIDI_Utils : TestSuite
    {
        public override void RunSuite()
        {
            ///// Export midi.
            StepCollection steps = new StepCollection();

            Dictionary<int, string> channels = new Dictionary<int, string>();
            new List<int>() { 1, 2, 3 }.ForEach(i => channels.Add(i, $"CHANNEL_{i}"));

            MidiUtils.ExportMidi(steps, "midiFileName", channels, 1.0, "string info");

            ///// Import midi.
            var v = MidiUtils.ImportFile(@"C:\Users\cet\OneDrive\Audio\Midi\real-songs\WICKGAME.MID");
            //..\Files\ambient.mid
            //..\Files\Funk.sty
            //C:\Users\cet\OneDrive\Audio\Midi\real-songs\WICKGAME.MID

            Clipboard.SetText(string.Join(Environment.NewLine, v));
        }
    }
}
