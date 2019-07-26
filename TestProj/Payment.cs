using System;

namespace TestProj
{
    internal class Payment
    {
        private MyTime myTime;

        public Payment(MyTime myTime)
        {
            this.myTime = myTime;
        }
        public Payment()
        {
            this.myTime = new RealTime();
        }

        internal bool pay(int v)
        {
            TimeSpan currentTime = myTime.TimeOfDay();
            TimeSpan dueTime = new TimeSpan(22, 0, 0);
            return currentTime < dueTime;
        }
    }
}