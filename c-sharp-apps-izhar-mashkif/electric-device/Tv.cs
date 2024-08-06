﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.electric_device
{
    public class Tv : Screen
    {
        private bool onoff;

        public Tv(bool onoff) : base(0)
        {
            this.onoff = onoff;
        }
        public void DisplayTv()
        {
            base.DisplayScreen();
            Console.WriteLine($"on/off {onoff}");
        }
    }
}
