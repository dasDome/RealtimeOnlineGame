using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Receiver
    {
        private TcpClient client;
        public NetworkStream tcpStream { get; set; }
        public Queue buffer;
        public String[] responseDataArray;
        public bool isconnected { get; set; }
        public Parser parse;
        public GuiV1 g;
        

        public Receiver(TcpClient client)
        {
            this.client = client;
            tcpStream = client.GetStream();
            buffer = new Queue();            
        }

        public Receiver(TcpClient client, Parser p, GuiV1 gui)
        {
            this.client = client;
            tcpStream = client.GetStream();
            buffer = new Queue();
            parse = p;
            g = gui;
            
        }

        public GuiV1 getGui() 
        {
            return g;
        }

        public void receive()
        {
            while (isconnected)
            {
                if (tcpStream.CanRead)
                {

                    try
                    {
                        /*Console.WriteLine("Empfange");
                        Console.WriteLine("----------------------");Schleife hierhin*/

                        tcpStream = client.GetStream();
                        Byte[] data = new Byte[32768];

                        String responseData = String.Empty;
                        /*if (tcpStream.CanRead)
                        {
                            Console.WriteLine("konnte stream lesen");
                        }
                        Console.WriteLine("----------------------");*/
                        int bytes = tcpStream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                        /*responseDataArray = responseData.Split((char)13);
                        for (int k = 0; k < responseDataArray.Length; k++)
                        {
                            buffer.Add(responseDataArray[k]);
                        }*/
                        buffer.Enqueue(responseData);
                        //Console.WriteLine("#####"+buffer.Dequeue());
                        //parse = new Parser(buffer);
                        //g.textBox1.Text = "ALALALALALALA";
                        //Console.WriteLine(parse.GetType());
                        parse.makeArray2(buffer, g);

                        /*for (int i = 0; i < buffer.Count; i++)
                        {
                            Console.WriteLine("jhdf");
                           //Console.WriteLine(buffer.Dequeue());
                           //Console.WriteLine("Buffer["+i+"]"+buffer[i].ToString());
                        }*/

                        //Console.WriteLine(responseData);

                    }

                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine("ArgumentNullException: {0}", e);
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine("SocketException: {0}", e);
                    }
                    /*Console.WriteLine("\n Press Enter to continue...");
                    Console.Read();*/

                }

                else
                {
                    Console.WriteLine("Keine Verbindung-Beliebige taste zum schliessen");
                    //Console.ReadKey(true);
                }

            }       
        }
    }
}
