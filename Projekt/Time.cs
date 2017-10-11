using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Time
    {
        private long time;

        public Time()
        {
            time = 0;
        }

        public Time(long time)
        {
            this.time = time;
        }

        public String toString()
        {
            return ("TIME: " + this.time);
        }
    }
}
