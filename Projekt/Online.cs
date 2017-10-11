using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Online
    {
        private int on;

        public Online()
        {
            this.on = 0;
        }

        public Online(int on)
        {
            this.on = on;
        }

        public int getOnline()
        {
            return this.on;
        }

        public void setOnline(int on)
        {
            this.on = on;
        }

        public void toString()
        {
            Console.WriteLine("Online: " + this.on);
        }
    }
}
