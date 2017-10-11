using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Projekt
{
    class Message
    {
        private int srcid { get; set; }
        private String src { get; set; }
        private String txt { get; set; }

        public Message()
        {
            this.srcid = 0;
            this.src = "";
            this.txt = "";
        }

        public Message(Dictionary<String, String> msg)
        {
            this.srcid = int.Parse(msg["srcid"]);
            this.src = msg["src"];
            this.txt = msg["txt"];
        }

        public String getMessage()
        {
            String chat = "["+this.src+"] " + this.txt;
            return chat;
        }

        public int getSrcid()
        {
            return this.srcid;
        }

        public String getSrc()
        {
            return this.src;
        }

        public void toString()
        {
            Console.WriteLine("SRCID: " + this.srcid + " SRC: " + this.src + " TXT: " + this.txt);
        }
    }
}
