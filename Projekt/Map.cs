using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace Projekt
{
    public class Map
    {
        public List<List<Mapcell>> cell = new List<List<Mapcell>>();
        public int height;
        public int width;

        public Map(Dictionary<string, string> text, List<List<Mapcell>> cell)
        {
            this.cell.Add(new List<Mapcell>());
            this.height = int.Parse(text["height"]);
            this.width = int.Parse(text["width"]);
            this.cell = cell;
        }
        public int getHeight()
        {
            return this.height;
        }
        public int getWidth()
        {
            return this.width;
        }

        public Mapcell getMapcell(int row, int col)
        {
            Mapcell mc = new Mapcell();
            for (int i = 0; i < this.width; i++ )
            {
                for (int j = 0; j < this.height; j++ )
                {
                    if (this.cell[i][j].getRow() == 0 && this.cell[i][j].getCol() == 0)
                        mc = this.cell[i][j]; 
                }
        
            }
            return mc;
        }

        public List<List<Mapcell>> getCells()
        {
            return this.cell;
        }
        public void toString()
        {
            String s = "";
            for (int i = 0; i < this.width; i++ )
            {
                for (int j = 0; j < this.height; j++ )
                {
                    s += this.cell[i][j].getProp()+" ";

                }
                s += "\n";
            }
            Console.WriteLine(s);
        }
    }
}
