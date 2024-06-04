﻿using c_sharp_apps_izhar_mashkif.BankApp;
using c_sharp_apps_izhar_mashkif.DraftApp;
using c_sharp_apps_izhar_mashkif.SportApp;
using c_sharp_apps_izhar_mashkif.TransportationApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.Common
{
    public class ProcessManager
    {
        public static void RunMainProcess ()
        {
            Console.WriteLine("Choose one options: ");
            Console.WriteLine("1 – Bank App | 2 – Sport App | 3 – Transportation App | 4 – Draft App | 0- Exit");

            int choose = int.Parse(Console.ReadLine());

            while (choose != 0)
            {
                switch (choose)
                {
                    case 0:
                        Console.WriteLine("App Exit");
                        return;
                    case 1:
                        BankAppMain.MainEntry();
                        break;
                    case 2:
                        SportAppMain.MainEntry();
                        break;
                    case 3:
                        TransportationAppMain.MainEntry();
                        break;
                    case 4:
                        DraftAppMain.MainEntry();
                        break;
                }

                Console.WriteLine("Choose one options: ");
                Console.WriteLine("1 – Bank App | 2 – Sport App | 3 – Transportation App | 4 – Draft App | 0- Exit");

                choose = int.Parse(Console.ReadLine());

            }
        }
    }
}
