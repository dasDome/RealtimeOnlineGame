using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Opponent
    {
        private int id, points, total;
        private String dssprop;

        public Opponent(Dictionary<String, String> opp)
        {
            this.id = int.Parse(opp["id"]);
            this.points = int.Parse(opp["points"]);
            this.total = int.Parse(opp["total"]);
            this.dssprop = opp["dssproperties"];
        }

        public void toString()
        {
            Console.WriteLine("Id:" + this.id + " Points:" + this.points + " Total:" + this.total + " Dssproperty:" + this.dssprop);
        }
    }
}
