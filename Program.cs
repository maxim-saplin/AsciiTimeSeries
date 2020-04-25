using System;
using System.Collections.Generic;
using System.Threading;

namespace Saplin.TimeSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            var series = new List<double>();
            var  awaiter = new ManualResetEventSlim(false);
            var timer = new System.Timers.Timer();
            var rand = new Random();
            int n = -60;

            var ascii = new AsciiTimeSeries();
            ascii.HeigthLines = 15;
            ascii.WidthCharacters = 50;
            ascii.EmptyChar = '`';
            ascii.AbovePointChar = '`';
            ascii.Series = series;

            timer.Elapsed += (s, e) =>
            {
                series.Add(5 * Math.Cos(Math.PI * n / 45) * (1 + 0.2 * rand.NextDouble()) + 1.85 * rand.NextDouble());
                n++;
                Console.WriteLine(ascii.RenderToString());
                Console.CursorTop -= ascii.HeigthLines;
            };

            timer.Interval = 200;
            timer.AutoReset = true;
            timer.Enabled = true;
            Console.WriteLine("Press any key to quit");
            awaiter.Wait();
        }
    }
}