﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubblegumMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Gui gui = new Gui();
            Dispenser dispenser = new Dispenser();
            gui.RenderMenu();
            dispenser.FillDispenser();
            //dispenser.PrintBubblegum();
            dispenser.DrawRandomGum();
    }
    }
}
