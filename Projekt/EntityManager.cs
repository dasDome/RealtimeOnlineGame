using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class EntityManager
    {
        List<Dragon> dragon;
        List<Player> player;
        List<Object> liste = new List<Object>();

        public EntityManager()
        {
            dragon = new List<Dragon>();
            player = new List<Player>();
        }

        public void addDragon(Dragon dragon)
        {
            if (isvalidDragon(dragon))
            {
                this.dragon.Add(dragon);
                if (dragon.getonlyid() == false)
                dragon.toString();
            }

            else
            {
                Console.WriteLine(dragon.ToString()+"---Dragon mit identischen Werten bereits vorhanden---");
            }
        }

        public void addPlayer(Player player)
        {
            if (isvalidPlayer(player))
            {
                this.player.Add(player);
                if(player.getonlyid() == false)
                player.toString();
            }

            else
            {
                Console.WriteLine(player.ToString()+"---Player mit identischen Werten bereits vorhanden---");
            }
        }

        public Boolean isvalidPlayer(Player player)
        {
            for (int i = 0; i < this.player.Count; i++)
            {
                if (this.player[i].getId() == player.getId())
                {
                    return false;
                }
            }
            return true;
        }

        public Boolean isvalidDragon(Dragon dragon)
        {
            for (int i = 0; i < this.dragon.Count; i++)
            {
                if (this.dragon[i].getId() == dragon.getId())
                {
                    return false;
                }
            }
            return true;
        }

        public void deleteDragon(int dragonid)
        {
            for (int i = 0; i < dragon.Count; i++)
            {
                if (this.dragon[i].getId() == dragonid)
                {
                    this.dragon[i] = null;
                    GC.Collect(GC.GetGeneration(this.dragon[i]));
                    break;
                }
            }
        }

        public void deletePlayer(int playerid)
        {
            for (int i = 0; i < player.Count; i++)
            {
                if (this.player[i].getId() == playerid)
                {
                    this.player[i] = null;
                    GC.Collect(GC.GetGeneration(this.player[i]));
                    break;
                }
            }
        }

        public Player getPlayer(int playerid)
        {
            int zahl = 0;
            for (int i = 0; i < player.Count; i++)
            {
                if (this.player[i].getId() == playerid)
                {
                    zahl = i;
                    break;
                }
            }
            return this.player[zahl];
        }

        public Dragon getDragon(int dragonid)
        {
            int zahl = 0;
            for (int i = 0; i < dragon.Count; i++)
            {
                if (this.dragon[i].getId() == dragonid)
                {
                    zahl = i;
                    break;
                }
            }
            return this.dragon[zahl];
        }

        public List<Player> getallPlayerList()
        {
            return player;
        }

        public List<Dragon> getallDragonList()
        {
            return dragon;
        }


        public List<Object> getPlayerList()
        {
            for (int i = 0; i < player.Count; i++)
            {
                liste.Add((Object)player.ElementAt(i));
            }
            return liste;
        }

        public List<Object> getSortPlayerList()
        {
            return liste;
        }
    }
}
