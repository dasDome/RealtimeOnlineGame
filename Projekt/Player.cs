using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Projekt
{
    public class Player
    {
       // private static int yourid;
        private int id;
        private int x;
        private int y;
        private int points;
        private String type;
        private Boolean busy;
        private String desc;
        private Boolean onlyid;

        public Player()
        {
            this.id = 0;
            this.x = 0;
            this.y = 0;
            this.points = 0;
            this.desc = "";
            this.busy = false;
            this.type = "";
            onlyid = false;
            //yourid = 0;
        }

        public Player(int id)
        {
            this.id = id;
            this.x = 0;
            this.y = 0;
            this.points = 0;
            this.desc = "";
            this.busy = false;
            this.type = "";
            this.onlyid = true;
            //yourid = 0;
        }

        public Player(int id, int x, int y, int points)
        {
            this.id = id;
            this.x = x;
            this.y = y;
            this.points = points;
            //yourid = id;
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

        public int getPoints()
        {
            return this.points;
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
            this.id =id;
        }

        public void setX(int x)
        {
            this.x=x;
        }

        public void setY(int y)
        {
            this.y=y;
        }

        public void setPoints(int points)
        {
            this.points=points;
        }

        public void setType(String type)
        {
            this.type=type;
        }

        public void setBusy(bool busy)
        {
            this.busy=busy;
        }

        public void setdesc(String desc)
        {
            this.desc=desc;
        }

        public Player(Dictionary<String, String> bla)
        {
            this.id = int.Parse(bla["id"]);
            this.x = int.Parse(bla["x"]);
            this.y = int.Parse(bla["y"]);
            this.points = int.Parse(bla["points"]);
            this.type = bla["type"];
            this.busy = bool.Parse(bla["busy"]);
            this.desc = bla["desc"];

           // yourid = int.Parse(bla["id"]);
        }
      
      //  public static int getId()
      //  {
     //           return yourid;
    //    }


        public void toString()
        {
            Console.WriteLine("ID: " + this.id + " X: " + this.x + " Y: " + this.y + " Points: " + this.points + " TYPE: " + this.type + " BUSY: " + this.busy + " DESC: " + this.desc);
        }

        public String ToString()
        {
            return ("ID: " + this.id + " X: " + this.x + " Y: " + this.y + " Points: " + this.points + " TYPE: " + this.type + " BUSY: " + this.busy + " DESC: " + this.desc);
        }
    }
}
