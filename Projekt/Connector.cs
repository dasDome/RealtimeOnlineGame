using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Collections;

namespace Projekt
{
    class Connector
    {
        private static TcpClient client;
        private Receiver empf;
        private Sender senter;
        private Thread receiveT;
        private Thread senderT;


        public Connector(GuiV1 gui)
        {
            Console.WriteLine("Connect...");
            //client = new TcpClient("127.0.0.1", 23); //->Hercules
            //client = new TcpClient("85.214.103.114", 110);
            client = new TcpClient("127.0.0.1", 666);
            client.ReceiveBufferSize = 128000;
            Queue serv = new testMap().getTestMap();
            Parser parser = new Parser(serv, gui, true);
            //senter = new Sender(client);
            //senter.sendtext("get:map");
            //Parser parser = new Parser();
            empf = new Receiver(client,parser,gui);
            senter = new Sender(client);
         
            receiveT = new Thread(new ThreadStart(empf.receive));
            senderT = new Thread(new ThreadStart(senter.send));

            senter.isconnected = client.Connected;
            empf.isconnected = client.Connected;
            receiveT.Start();
            senderT.Start();
        }

        public Sender getSender()
        {
            return senter;
        }
 

        public Receiver getEmpfänger()
        {
            return empf;
        }
       
    }
}
