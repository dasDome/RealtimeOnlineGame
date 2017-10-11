using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Projekt
{
    class Sender
    {
        private Boolean _antw = false;
        public bool isconnected { get; set; }
        public Boolean antw
        {
            get { return _antw; }
            set { _antw = value; }
        }

        private TcpClient client;
        public NetworkStream tcpStream { get; set; }
        public Sender(TcpClient client)
        {
            this.client = client;
            tcpStream = client.GetStream();
            //this.sendtext("get:map");
        }
        

        public void send()
        {
            //string inputString = Console.ReadLine();

            //Console.WriteLine(isconnected);
            while (isconnected)
            {
                //this.isconnected = this.client.Connected;
                if (tcpStream.CanRead)
                {

                    try
                    {
                        String message = Console.ReadLine().ToString();// "Senden test";
                        //message = "ask:say:hahahhaa" + "\n";
                        message = "get:ents" + "\n";
                        if (message != "")
                        {
                            Console.WriteLine("Sende");
                            Console.WriteLine("----------------------");
                        }

                        Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                        if (message != "")
                        {
                            Console.WriteLine("Sent: {0}", message);
                        }

                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine("ArgumentNullException: {0}", e);
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine("SocketException: {0}", e);
                    }
                }
            }
        }




        public void sendtext(String text)
        {
            //while (isconnected)
            //{
                //this.isconnected = this.client.Connected;
                if (tcpStream.CanRead)
                {

                    try
                    {
                        String message = text + "\n";
                        if (message != "")
                        {
                            Console.WriteLine("Sende");
                            Console.WriteLine("----------------------");
                        }

                        Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
                        NetworkStream stream = client.GetStream();
                        stream.Write(data, 0, data.Length);
                        if (message != "")
                        {
                            Console.WriteLine("Sent: {0}", message);
                        }

                    }
                    catch (ArgumentNullException e)
                    {
                        Console.WriteLine("ArgumentNullException: {0}", e);
                    }
                    catch (SocketException e)
                    {
                        Console.WriteLine("SocketException: {0}", e);
                    }
                }
            //}
        }





        public void close()
        {
            client.Close();
        }
    }
}
