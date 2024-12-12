using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnClassLibrary
{
    public class LearnClass
    {
        public int TimeInSecunds(int a, int b)
        {
            return a * 3600 + b * 60;
        }
        public int TimeInHour(int a)
        {
            int hour = (a / 3600);
            return hour;
        }
        public int TimeInMin(int a)
        {
            return ((a / 60) - TimeInHour(a) * 60);
        }
    }
}
