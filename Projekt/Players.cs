using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Players
    {
        private String info;

        public Players(String info)
        {
            this.info = info;
        }


        public void toString()
        {
            Console.WriteLine("Players: " + this.info);
        }
    }
}
