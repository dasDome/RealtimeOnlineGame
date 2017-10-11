using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    public class Dragon
    {
        private int id;
        private int x ;
        private int y; 
        private String type ;
        private Boolean busy ;
        private String desc ;
        private Boolean onlyid;

        public Dragon()
        {
            this.id = 0;
            this.x = 0;
            this.y = 0;
            this.onlyid = false;
            this.type = "";
            this.desc = "";
            this.busy = false;
        }

        public Dragon(int id)
        {
            this.id = id;
            this.x = 0;
            this.y = 0;
            this.desc = "";
            this.busy = false;
            this.type = "";
            this.onlyid = true;
            //yourid = 0;
        }
        public Dragon(int id, int x, int y)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.onlyid = false;
        }

        public Boolean getonlyid()
        {
            return onlyid;
        }

        public int getId()
        {
            return this.id;
        }

        public int getX()
        {
            return this.x;
        }

        public int getY()
        {
            return this.y;
        }

        public String getType()
        {
            return this.type;
        }

        public bool getBusy()
        {
            return this.busy;
        }

        public String getdesc()
        {
            return this.desc;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setX(int x)
        {
            this.x = x;
        }

        public void setY(int y)
        {
            this.y = y;
        }

        public void setType(String type)
        {
            this.type = type;
        }

        public void setBusy(bool busy)
        {
            this.busy = busy;
        }

        public void setdesc(String desc)
        {
            this.desc = desc;
        }

        public Dragon(Dictionary<String, String> bla)
        {
            this.id = int.Parse(bla["id"]);
            this.x = int.Parse(bla["x"]);
            this.y = int.Parse(bla["y"]);
            this.type = bla["type"];
            this.busy = bool.Parse(bla["busy"]);
            this.desc = bla["desc"];
        }
        public void toString(){
            Console.WriteLine("ID: " + this.id + " X: " + this.x + " Y: " + this.y + " TYPE: " + this.type + " BUSY: " + this.busy + " DESC: " + this.desc);
        }
        public String ToString()
        {
            return ("ID: " + this.id + " X: " + this.x + " Y: " + this.y + " TYPE: " + this.type + " BUSY: " + this.busy + " DESC: " + this.desc);
        }

    }
}
