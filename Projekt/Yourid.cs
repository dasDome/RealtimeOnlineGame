using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Yourid
    {
        private int yourid;

        public Yourid()
        {
            this.yourid = 0;
            //this.yourid = Player.getId();
        }

        public Yourid(int yourid)
        {
            this.yourid = yourid;
            //this.yourid = Player.getId();
        }

        public int getId()
        {
            return this.yourid;
        }

        public void setId(int yourid)
        {
            this.yourid = yourid;
        }

        public void toString()
        {
            Console.WriteLine("YOURID: " + this.yourid);
        }
    }
}
