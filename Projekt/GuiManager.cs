using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;

namespace Projekt
{
    class GuiManager
    {
        GuiV1 gui;

        public GuiManager()
        {
            gui = new GuiV1();
        }

        public GuiV1 getGui()
        {
            return gui;
        }

    }
}
