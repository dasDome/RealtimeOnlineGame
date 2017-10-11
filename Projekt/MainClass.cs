using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Projekt
{
    static class MainClass
    {
        [STAThread]
        static void Main(string[] args)
        {
            Queue serv = new Queue();
         
            // ----------------Player erzeugen + delete---------------------
            /*serv.Enqueue("begin:10");
            serv.Enqueue("begin:player");
            serv.Enqueue("id:229");
            serv.Enqueue("type:Player");
            serv.Enqueue("busy:false");
            serv.Enqueue("desc:Player228");
            serv.Enqueue("x:5");
            serv.Enqueue("y:9");
            serv.Enqueue("points:0");
            serv.Enqueue("end:player");
            serv.Enqueue("end:10");

            serv.Enqueue("begin:11");
            serv.Enqueue("begin:del");
            serv.Enqueue("begin:player");
            serv.Enqueue("id:229");
            serv.Enqueue("type:Player");
            serv.Enqueue("busy:false");
            serv.Enqueue("desc:Player228");
            serv.Enqueue("x:5");
            serv.Enqueue("y:9");
            serv.Enqueue("points:0");
            serv.Enqueue("end:player");
            serv.Enqueue("end:del");
            serv.Enqueue("end:11");*/
             
            // ----------------Player erzeugen + update---------------------
            /*
            serv.Enqueue("begin:12");
            serv.Enqueue("begin:player");
            serv.Enqueue("id:229");
            serv.Enqueue("type:Player");
            serv.Enqueue("busy:false");
            serv.Enqueue("desc:Player228");
            serv.Enqueue("x:5");
            serv.Enqueue("y:9");
            serv.Enqueue("points:0");
            serv.Enqueue("end:player");
            serv.Enqueue("end:12");

            serv.Enqueue("begin:13");
            serv.Enqueue("begin:upd");
            serv.Enqueue("begin:player");
            serv.Enqueue("id:229");
            serv.Enqueue("type:Player");
            serv.Enqueue("busy:false");
            serv.Enqueue("desc:Player228");
            serv.Enqueue("x:6");
            serv.Enqueue("y:9");
            serv.Enqueue("points:10");
            serv.Enqueue("end:player");
            serv.Enqueue("end:upd");
            serv.Enqueue("end:13"); 
            */
       
            // ----------------Map erzeugen + update---------------------

           /* serv.Enqueue("begin:14");
            serv.Enqueue("begin:upd");
            serv.Enqueue("begin:cell");
            serv.Enqueue("row:0");
            serv.Enqueue("col:0");
            serv.Enqueue("begin:props");
            serv.Enqueue("WATER");
            serv.Enqueue("end:props");
            serv.Enqueue("end:cell");
            serv.Enqueue("end:upd");
            serv.Enqueue("end:14"); */



            /*
            //Parser p = new Parser(serv);
            Connector test = new Connector();
            Console.ReadKey(true);*/
            /*EntityManager entmanager = new EntityManager();
            Random random = new Random();

            for (int i = 0; i < 8; i++)
            {
                Player player = new Player();

                int randomNumber = random.Next(0, 100);
                player.setPoints(randomNumber);
                player.setId(i);
                entmanager.addPlayer(player);

            }
            Quicksort.sort(entmanager.getPlayerList());

            for (int i = 0; i < 8; i++)
            {
                Player p1 = (Player)entmanager.getSortPlayerList().ElementAt(i);
                p1.toString();
            }*/

            //IMatcher m = new IMatcher();
            //m.ismatch();

            /*
            Player z = new Player(1, 1, 1, 1);
            Player g = new Player(2, 2,2,100);
            g.setBusy(true);

            Comparator<Boolean> comp1 = new Comparator<Boolean>();
            Console.WriteLine(comp1.compare(z.getBusy(),g.getBusy()));



            Console.ReadKey(true);*/

            //GuiV1 gui = new GuiV1();
            //Console.ReadKey(true);
                   

           // Application.EnableVisualStyles();
           // Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new GuiV1());
           
            
            //Parser p = new Parser(serv);
            //Connector test = new Connector();
            
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);            
            /*GuiManager g = new GuiManager();
            for(int i=0; i<10; i++)
            g.getGui().setTextBox1("AAAAAAAAAAAA");
            g.getGui().setTextBox2("BBBBBBBBBB");*/
            
            GameManager m = new GameManager();









//-----------------------Am Ende hin-------------------------------\\
//-----------------------Danach keine Eingabe mehr möglich-------------------------------\\
            Application.Run(m.getGui());



            Console.ReadKey(true);

        }
        /*
        static void Main(string[] args)
        {
            Connector test = new Connector();
        }*/
        
    }
}
