using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Projekt
{
    class Entities
    {
        private String info;

        public Entities(String info)
        {
            this.info = info;
        }


        public void toString()
        {
            Console.WriteLine("Entities: " + this.info);
        }
    }
}
