using System;
using System.Timers;

// Disable nullables because they are kinda annoying
#nullable disable

namespace EZMetronome
{
    public class EZMetronomeTimer : System.Timers.Timer
    {
        private System.Timers.Timer _timer;
        public ElapsedEventHandler metroTick;
        public int metroTicks;
        public float metroBPM;

        public EZMetronomeTimer()
        {
            metroBPM = 60;

            _timer = new System.Timers.Timer();
            _timer.Elapsed += metronome_Ticked;
            _timer.Interval = (60.000 / metroBPM) * 1000;
            _timer.Start();

            metroTick += metronome_Ticked;
        }

        public void SetBPM(float bpm)
        {
            _timer.Stop();

            metroBPM = bpm;
            Console.WriteLine(_timer.Interval = (60.000 / metroBPM) * 1000);
            metroTicks = 0;

            _timer.Start();
        }

        private void metronome_Ticked(object obj, ElapsedEventArgs args)
        {
            metroTicks++;
            int i = 0;
            Math.DivRem(metroTicks, 4, out i);
            bool isMain = (i == 0);

            System.Diagnostics.Debug.WriteLine($"tick: main? {isMain}, divRem {i}, tickCount {metroTicks}");
            Console.WriteLine($"tick: main? {isMain}, divRem {i}, tickCount {metroTicks}");
        }
    }

    internal class Program
    {
        public static void Main()
        {
            Console.Write("Welcome, please insert the bpm: ");
            int bpm = int.Parse(Console.ReadLine());

            EZMetronomeTimer metronome = new EZMetronomeTimer();
            metronome.SetBPM(bpm);

            Console.ReadLine();
        }
    }
}