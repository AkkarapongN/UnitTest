using System;
using System.Collections.Generic;
using System.Text;

namespace TestProj
{
    class RealTime : MyTime
    {
        public TimeSpan TimeOfDay()
        {
            return DateTime.Now.TimeOfDay;
        }
    }
}
