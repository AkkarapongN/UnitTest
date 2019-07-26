using System;

namespace TestProj
{
    internal class StubTime : MyTime
    {
        private int hh;
        private int mm;
        private int ss;

        public StubTime()
        {
        }

        public StubTime(int hh, int mm, int ss)
        {
            this.hh = hh;
            this.mm = mm;
            this.ss = ss;
        }

        public TimeSpan TimeOfDay()
        {
            return new TimeSpan(hh, mm, ss);
        }
    }
}