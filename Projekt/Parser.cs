using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Projekt
{
    class Parser
    {
        //private String[] text;
        //private Dictionary<string, IEnumerable<string>> text2 = new Dictionary<string, IEnumerable<string>>();
        private Dictionary<string, string> text2 = new Dictionary<string, string>();
        private Dictionary<string, string> text3 = new Dictionary<string, string>();
        private long[] zahl = new long[2];
        private int zahl2;
        ArrayList test = new ArrayList();
        ArrayList container = new ArrayList();
        private int zähler {get; set;}
        private Boolean isProp { get; set; }
        private ArrayList mapArray { get; set; }
        private String props { get; set; }
        private static EntityManager entmanager = new EntityManager();
        private Map maptest;
        public GuiV1 gui;
        String[] temp;

        
        public Parser(Queue server)
        {
            this.zähler = server.Count;
            this.makeArray(server);
            //this.parsen(server);
        }
        public Parser(Queue server, GuiV1 g, Boolean test)
        {
            this.zähler = server.Count;
            gui = g;
            //this.makeArray(server);
            this.parsen(server);
            
        }
        public Parser(Queue server, GuiV1 g)
        {
            this.zähler = server.Count;
            this.makeArray(server);
            gui = g;
            //this.parsen(server);
        }
        public Parser() 
        { }


        public void makeArray(Queue server)
        {
            String[] liste;
            Queue serv = new Queue();
            string replaceWith = "|";
            string removedBreaks = server.Dequeue().ToString().Replace("\r\n", replaceWith);
            Regex myRegex = new Regex(@"[|]");
            if (myRegex.IsMatch(removedBreaks))
            {
                liste = removedBreaks.Split('|');
                for (int i = 0; i < liste.Count(); i++)
                {
                    if (liste[i] != "")
                    {
                        //Console.WriteLine("#" + liste[i]);
                        serv.Enqueue(liste[i]);
                    }
                }
            }
            this.zähler = serv.Count;
            this.parsen(serv);
        }



        public void makeArray2(Queue server, GuiV1 g)
        {
            String[] liste;
            Queue serv = new Queue();
            string replaceWith = "|";
            string removedBreaks = server.Dequeue().ToString().Replace("\r\n", replaceWith);
            Regex myRegex = new Regex(@"[|]");
            if (myRegex.IsMatch(removedBreaks))
            {
                liste = removedBreaks.Split('|');
                for (int i = 0; i < liste.Count(); i++)
                {
                    if (liste[i] != "")
                    {
                        //Console.WriteLine("#" + liste[i]);
                        serv.Enqueue(liste[i]);
                    }
                }
            }
            this.zähler = serv.Count;
            setGui(g);
            this.parsen(serv);
        }

        public void setGui(GuiV1 g) 
        {
            this.gui = g;
        }
        public GuiV1 getGui() 
        {
            return this.gui;
        }
        public Boolean propertyCheck(String text)
        {
            String copy = text;
            Regex myRegex = new Regex(@"[:]{1}");
            if (myRegex.IsMatch(copy))
            {
                Console.WriteLine(false);
                return false;
            }
            else
            {
                Console.WriteLine(true);
                return true;
            }
        }

        //Überprüfung um welchen Typ es sich handelt, danach Sprung in die jeweilige Methode
        public void parsen(Queue serv2)
        {
            //System.Threading.Thread.Sleep(5000);
            Queue serv = serv2;
            if (serv2.Count > 0)
            {
                temp = serv.Dequeue().ToString().Split(':');
                    
                try { serv.Peek().ToString(); }
                catch {  }

                if (temp[0].Equals("begin"))
                {
                    /*if (temp[1].Equals("player"))
                    {
                        parsPlayer(temp, serv);
                        parsen(serv);
                        //System.Threading.Thread.Sleep(20000);
                    }

                    if (temp[1].Equals("dragon"))
                    {
                            parsDragon(temp, serv);
                            parsen(serv);
                           // System.Threading.Thread.Sleep(20000);
                    }*/

                    if (temp[1].Equals("yourid"))
                    {
                        parsYourId(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("time"))
                    {
                        parsTime(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("online"))
                    {
                        parsOnline(serv);
                        parsen(serv);
                    }
                    if (temp[1].Equals("mes"))
                    {
                        parsMes(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("server"))
                    {
                        parsServer(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("ents"))
                    {
                        parsEntities(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("map"))
                    {
                        parsMap(serv);
                        parsen(serv);
                    }
                    if (temp[1].Equals("player"))
                    {
                        parsPlayer(temp,serv);
                        parsen(serv);
                    }
                    if (temp[1].Equals("players"))
                    {
                        parsPlayers(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("del"))
                    {
                        parsDelete(serv);
                        parsen(serv);
                    }

                    if (temp[1].Equals("upd"))
                    {
                        this.parsUpdate(serv);
                        parsen(serv);
                    }

                    

                }
                /*if (temp[1].Equals("mapcell"))
                {
                    Console.WriteLine(temp[0] + ":" + temp[1]);
                    parsen(serv);
                }*/
                

                if (temp[0].Equals("end"))
                {
                    //Console.WriteLine(temp[0] + ":" + temp[1]);
                    parsen(serv);
                }
                /*if (temp[0].Equals("ans"))
                {
                    if(temp[])
                    parsen(serv);
                }*/
                else
                {
                    //Console.WriteLine(temp[0]+":"+temp[1]);
                    //text2.Add(temp[0], temp[1]);
                    parsen(serv);
                }
            }
        }

        /*
        #######################################################################
        Einzelne Parser Methoden
        #######################################################################
        */


        //Player Parsen
        private int parsPlayer(String[] temp, Queue serv)
        {
            
            while (!temp[0].Equals("end"))
            {
                temp = serv.Dequeue().ToString().Split(':');
                text2.Add(temp[0], temp[1]);
            }
            Player testplayer = new Player(text2);

            entmanager.addPlayer(testplayer);
            gui = getGui();
            //gui.setTextBox1("a");
            gui.setPlayerPanel(testplayer);
            Console.WriteLine("KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
            text2.Clear();
            return testplayer.getId();
            //text2.Add(temp[0], temp[1]);
        }

        //Dragon Parsen
        private void parsDragon(String[] temp, Queue serv)
        {
            while (!temp[0].Equals("end"))
            {
                temp = serv.Dequeue().ToString().Split(':');

                text2.Add(temp[0], temp[1]);
            }
            Dragon testdragon = new Dragon(text2);
            entmanager.addDragon(testdragon);
            text2.Clear();
            //text2.Add(temp[0], temp[1]);
        }

        //YourId parsen
        private void parsYourId(Queue serv)
        {
            while (!temp[0].Equals("end"))
            {
                try
                {
                    temp = serv.Dequeue().ToString().Split(':');
                    text2.Add(temp[0], temp[1]);
                }
                catch
                {
                    zahl2 = int.Parse(temp[0]);
                }
            }
            Yourid testyourid = new Yourid(zahl2);
            text2.Clear();
            testyourid.toString();
        }

        //Time parsen
        private void parsTime(Queue serv)
        {
            long time = 0;
            while (!temp[0].Equals("end"))
            {
                time = long.Parse(serv.Dequeue().ToString());
                temp = serv.Dequeue().ToString().Split(':');
            }

            Time testtime = new Time(time);
            gui = getGui();
            gui.setTextBox1(testtime.toString());
            text2.Clear();
            Console.WriteLine(testtime.toString());
        }

        //Online parsen
        private void parsOnline(Queue serv)
        {
            while (!temp[0].Equals("end"))
            {
                try
                {
                    temp = serv.Dequeue().ToString().Split(':');
                    text2.Add(temp[0], temp[1]);
                }
                catch
                {
                    zahl2 = int.Parse(temp[0]);
                }
            }
            Online testonline = new Online(zahl2);
            text2.Clear();
            testonline.toString();
        }
        
        //Mess parsen
        private void parsMes(Queue serv)
        {
            while (!temp[0].Equals("end"))
            {
                temp = serv.Dequeue().ToString().Split(':');
                text2.Add(temp[0], temp[1]);
            }
            Message mes = new Message(text2);
            //gui.textBox1.Text = testmes.getMessage();
            gui = getGui();
            gui.setTextBox1(mes.getMessage());
            text2.Clear();
            
            mes.toString();
            //text2.Add(temp[0], temp[1]);
        }

        //Server parsen
        private void parsServer(Queue serv)
        {
            while (!temp[0].Equals("end"))
            {
                temp = serv.Dequeue().ToString().Split(':');
                text2.Add(temp[0], temp[1]);
            }
            Server testserver = new Server(text2);
            text2.Clear();

            testserver.toString();
            //text2.Add(temp[0], temp[1]);
        }

        //Entities parsen
        private void parsEntities(Queue serv)
        {
            String info="";
            temp=serv.Dequeue().ToString().Split(':');
            while(!(temp[0] == "end" && temp[1] == "ents"))
            {
                if (temp[0] == "begin" && temp[1] == "player")
                {
                    parsPlayer(temp, serv);
                    temp = serv.Dequeue().ToString().Split(':');
                }

                if (temp[0] == "begin" && temp[1] == "dragon")
                {
                    parsDragon(temp, serv);
                    temp = serv.Dequeue().ToString().Split(':');
                }
            }
            Entities ent = new Entities(info);
            ent.toString();
            info = "";
        }

        //Mapparsen
        private void parsMap(Queue serv) 
        {
            //MAP: " begin :map" , " width : " INT, " he i ght : " , INT, " begin : c e l l s " , {MAPCELL} , " end : c e l l s " , " end :map"
            text2.Clear();
            temp = serv.Dequeue().ToString().Split(':');
            text2.Add(temp[0], temp[1]);
            temp = serv.Dequeue().ToString().Split(':');
            text2.Add(temp[0], temp[1]);

            int width = int.Parse(text2["width"]);
            Console.WriteLine("breite: " + width);
            int height = int.Parse(text2["height"]);
            int row = 0;
            int col = 0;
            int anz = width * height;
            List<List<Mapcell>> cell = new List<List<Mapcell>>();

            String gelesen = serv.Dequeue().ToString();
            if (gelesen.Equals("begin:cells"))
            {
                gelesen = serv.Dequeue().ToString();
            }
            for (int i = 0; i <= anz; i++)
            {
                if (gelesen.Equals("begin:cell"))
                {
                    gelesen = serv.Dequeue().ToString();
                    temp = gelesen.Split(':');
                    text3.Add(temp[0], temp[1]);
                    row = int.Parse(temp[1]);
                    gelesen = serv.Dequeue().ToString();
                    temp = gelesen.Split(':');
                    text3.Add(temp[0], temp[1]);
                    col = int.Parse(temp[1]);
                    gelesen = serv.Dequeue().ToString();
                }
                if (gelesen.Equals("begin:props"))
                {
                    gelesen = serv.Dequeue().ToString();
                    //bla


                    String blubb="";
                    ///Per regex schaun ob : drin falls nein dann string konkat
                    ///String copy = text;
                    Boolean mehrere = false;
                    Regex myRegex = new Regex(@"[:]{1}");
                    while (!myRegex.IsMatch(gelesen)) {

                        if (mehrere == true)
                        {
                            blubb += "," + gelesen;
                        }
                        else
                        {
                            blubb = gelesen;
                            mehrere = true;
                        }

                        gelesen = serv.Dequeue().ToString();
                    }


                    text3.Add("properties", blubb);
                    gelesen = serv.Dequeue().ToString();

                }
                if (gelesen.Equals("end:props"))
                {
                    gelesen = serv.Dequeue().ToString();
                }
                if (gelesen.Equals("end:cell"))
                {
                    cell.Add(new List<Mapcell>()); 
                    cell[row].Add(new Mapcell(text3));
                    //Mapcell mapc = new Mapcell(text3);
                    //mapc.toString();
                    text3.Clear();
                    gelesen = serv.Dequeue().ToString();
                }
            }//neuer fehler kp muss cshauen k ich geh aus teamviewrr
            maptest = new Map(text2, cell);


            gui = getGui();
            //gui.setTextBox1("a");
            gui.setMapPanel(maptest);
            //this.bla(maptest);
            maptest.toString();
        }

        public void bla(Map n) {
            n.getHeight();
        }
        //Players parsen
        private void parsPlayers(Queue serv)
        {
            String info="";

            temp = serv.Dequeue().ToString().Split(':');
            while (!(temp[0] == "end" && temp[1] == "players"))
            {
                info += entmanager.getPlayer(parsPlayer(temp, serv)).ToString();
                temp = serv.Dequeue().ToString().Split(':');
            }
            Players plys = new Players(info);
            plys.toString();

        }

        private void parsDelete(Queue serv)
        {
            temp = serv.Dequeue().ToString().Split(':');

            if (temp[0] == "begin" && temp[1] == "player")
            {
                while (!(temp[0] == "end" && temp[1] == "player"))
                {
                    temp = serv.Dequeue().ToString().Split(':');
                    text2.Add(temp[0], temp[1]);
                }
            }

            if (temp[0] == "begin" && temp[1] == "dragon")
            {
                while (!(temp[0] == "end" && temp[1] == "dragon"))
                {
                    temp = serv.Dequeue().ToString().Split(':');
                    text2.Add(temp[0], temp[1]);
                }
            }

            Delete del = new Delete(text2, entmanager);
            text2.Clear();
        }

        private void parsUpdate(Queue serv)
        {
            Console.WriteLine("####################################################"+temp[0]+"  "+temp[1]);
            this.temp = serv.Dequeue().ToString().Split(':');
            if (this.temp[0].Equals("begin") && this.temp[1].Equals("player"))
            {
                while (!(this.temp[0].Equals("end") && this.temp[1].Equals("player")))
                {
                    try
                    {
                        this.temp = serv.Dequeue().ToString().Split(':');
                        text2.Add(this.temp[0], this.temp[1]);
                        Console.WriteLine(this.temp[0] + " : " + this.temp[1]);
                    }
                    catch{
                        Console.WriteLine("CATCH!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                        }
                }
                
            }

            if (this.temp[0] == "begin" && this.temp[1] == "dragon")
            {
                while (!(this.temp[0] == "end" && this.temp[1] == "dragon"))
                {
                    this.temp = serv.Dequeue().ToString().Split(':');
                    text2.Add(this.temp[0], this.temp[1]);
                }
            }

            if (this.temp[0] == "begin" && this.temp[1] == "cell")
            {
                Regex myRegex = new Regex(@"[:]{1}");
                String gelesen="";
                String prop = "";
                Boolean mehrere = false;

                while (!(this.temp[0] == "end" && this.temp[1] == "cell"))
                {                          
                    gelesen = serv.Dequeue().ToString();
                    if(myRegex.IsMatch(gelesen))
                    {
                        this.temp = gelesen.Split(':');
                        if (!gelesen.Equals("begin:props") && !gelesen.Equals("end:props"))
                        {
                            //Console.WriteLine(gelesen);
                            text2.Add(this.temp[0], this.temp[1]);
                        }
                    }

                    else
                    {
                        if(mehrere == false)
                        {
                            prop = gelesen;
                            mehrere = true;
                        }

                        else
                        {
                           prop += "," + gelesen;
                        }
                    }
                }
                text2.Add("properties", prop);
            }
            Update del = new Update(text2, entmanager, maptest, gui);
            gui = getGui();
            for (int i = 0; i < entmanager.getallPlayerList().Count; i++)
            {
                gui.setPlayerPanel(entmanager.getallPlayerList().ElementAt(i));
            }

            for (int j = 0; j < entmanager.getallDragonList().Count; j++)
            {
                gui.setDragonPanel(entmanager.getallDragonList().ElementAt(j));
            }
            //g.setPlayerPanel(entmanager.getPlayer(this.id));
            text2.Clear();
        }

        public void readLine() 
        {
        }
    }
}
