using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class Update
    {
        private int id;
        private String type;
        private int x;
        private int y;
        private int points;
        private Boolean busy;
        private String desc;
        private int row;
        private int col;
        public String prop;
        public GuiV1 g;

        public Update(Dictionary<String, String> upd, EntityManager entmanager, Map map, GuiV1 gui)
        {
            if (upd.ContainsKey("type"))
            {
                if (upd["type"].Equals("Dragon"))
                {
                    this.id = int.Parse(upd["id"]);
                    this.x = int.Parse(upd["x"]);
                    this.y = int.Parse(upd["y"]);
                    this.type = upd["type"];
                    this.busy = bool.Parse(upd["busy"]);
                    this.desc = upd["desc"];

                    Dragon d = new Dragon(this.id);
                    entmanager.addDragon(d);

                    entmanager.getDragon(this.id).setX(this.x);
                    entmanager.getDragon(this.id).setY(this.y);
                    entmanager.getDragon(this.id).setType(this.type);
                    entmanager.getDragon(this.id).setBusy(this.busy);
                    entmanager.getDragon(this.id).setdesc(this.desc);
                    entmanager.getDragon(this.id).toString();

                    g = gui;
                    g.setDragonPanel(entmanager.getDragon(this.id));
                    //entmanager.getDragon(this.id).toString();
                }

                if (upd["type"].Equals("Player"))
                {
                    this.id = int.Parse(upd["id"]);
                    this.x = int.Parse(upd["x"]);
                    this.y = int.Parse(upd["y"]);
                    this.points = int.Parse(upd["points"]);
                    this.type = upd["type"];
                    this.busy = bool.Parse(upd["busy"]);
                    this.desc = upd["desc"];

                    Player p = new Player(this.id);
                    entmanager.addPlayer(p);

                    entmanager.getPlayer(this.id).setX(this.x);
                    entmanager.getPlayer(this.id).setY(this.y);
                    entmanager.getPlayer(this.id).setPoints(this.points);
                    entmanager.getPlayer(this.id).setType(this.type);
                    entmanager.getPlayer(this.id).setBusy(this.busy);
                    entmanager.getPlayer(this.id).setdesc(this.desc);
                    Console.WriteLine("??????????????????????????????????????????????????");
                    
                    g = gui;
                    g.setPlayerPanel(entmanager.getPlayer(this.id));
                    entmanager.getPlayer(this.id).toString();
                }
            }

            else if (upd.ContainsKey("row") && upd.ContainsKey("col"))
            {
                this.row = int.Parse(upd["row"]);
                this.col = int.Parse(upd["col"]);
                this.prop = upd["properties"];

                map.getMapcell(this.row, this.col).setProperties(prop);
                map.getMapcell(this.row, this.col).toString();
            }

            else
            {
                Console.WriteLine("Update-fehler");
            }
            
        }
    }
}
