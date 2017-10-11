using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Projekt
{
    class Server
    {
        private int ver { get; set; }


        public Server()
        {
            this.ver = 0;
        }

        public Server(Dictionary<String, String> bla)
        {
            this.ver = int.Parse(bla["ver"]);
        }

        public void toString()
        {
            Console.WriteLine("VER: " + this.ver);
        }
    }
}
