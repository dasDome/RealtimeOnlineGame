using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Projekt
{
    public class Mapcell
    {
        private int row;
        private int col;
        private String prop;

        public Mapcell()
        {
            row=0;
            col=0;
            prop="";
        }

        public Mapcell(Dictionary<string, string> list)
        {
            this.row = int.Parse(list["row"]);
            this.col = int.Parse(list["col"]);
            this.prop = list["properties"];
        }

        public int getRow ()
        {
            return this.row;
        }

        public int getCol ()
        {
            return this.col;
        }

        public String getProp()
        {
            return this.prop;
        }

        public void setProperties(String prop)
        {
            this.prop = prop;
        }


        public void toString()
        {
            Console.WriteLine("row:" + this.row + " col:" + this.col + " props:" + this.prop);
        }

    }
}
