using System;
using System.Diagnostics;

namespace Projekt_3
{
    public abstract class ASorting
    {
        public string Type { get; set; }

        protected Stopwatch stopwatch = new Stopwatch();

        public TimeSpan ElapsedTime { get; protected set; } = new TimeSpan();

        abstract public void Sort(int[] tab);
    }
}
