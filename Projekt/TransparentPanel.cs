﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace Projekt
{
    public class TransparentPanel : System.Windows.Forms.Panel
    {
        [Browsable(false)]
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x20;
                return cp;
            }
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {
            // Do Nothing
        }
    }
}
