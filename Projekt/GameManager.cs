using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Projekt
{
    class GameManager
    {
        public GuiV1 g;

        public GameManager()
        {           
            g = new GuiV1();           
        }


        public GuiV1 getGui()
        {
            return g;
        }

    }
}
