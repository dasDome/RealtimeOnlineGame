using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Delete
    {
        private int id;
        private String type;
        private int x;
        private int y;
        private int points; 
        private Boolean busy; 
        private String desc;

        public Delete(Dictionary<String, String> del, EntityManager entmanager)
        {
            this.id = int.Parse(del["id"]);
            this.x = int.Parse(del["x"]);
            this.y = int.Parse(del["y"]);
            this.points = int.Parse(del["points"]);
            this.type = del["type"];
            this.busy = bool.Parse(del["busy"]);
            this.desc = del["desc"];

            if (this.type.Equals("Dragon"))
            {
                entmanager.deleteDragon(this.id);
            }

            if (this.type.Equals("Player"))
            {
                entmanager.deletePlayer(this.id);
            }

            Console.WriteLine(this.type+ " erfolgreich gelöscht!");
        }
    }
}
