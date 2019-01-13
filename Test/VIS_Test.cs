using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using PNUT;
using Nebulator.Synth;
using Nebulator.Visualizer;


namespace Nebulator.Test
{
    public class VIS_Basic : TestSuite
    {
        public override void RunSuite()
        {
            VisualizerForm v = new VisualizerForm
            {
                DotSize = 4,
                LineSize = 1,
                ChartType = ChartType.ScatterLine,
                Location = new Point(50, 50),
                StartPosition = FormStartPosition.Manual
            };

            //Random rand = new Random();
            //for (int y = 5; y < 100; y += 7)
            //{
            //    DataSeries ser = new DataSeries() { Name = $"S{y}" };
            //    for (int x = 1; x < 10; x++)
            //    {
            //        double dr = rand.NextDouble() * 3;
            //        //ser.Points.Add((x, y + dr));
            //        ser.AddPoint(x, dr);
            //    }
            //    v.AllSeries.Add(ser);
            //}

            DataSeries ser = new DataSeries() { Name = "TRI" };
            for (int x = 0; x < 100; x++)
            {
                double y = x % 25;
                ser.AddPoint(x, y);
            }
            v.AllSeries.Add(ser);

            new System.Threading.Thread(() => v.ShowDialog()).Start();
        }
    }
}
