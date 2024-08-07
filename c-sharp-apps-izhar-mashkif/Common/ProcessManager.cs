﻿using c_sharp_apps_izhar_mashkif.BankApp;
using c_sharp_apps_izhar_mashkif.DraftApp;
using c_sharp_apps_izhar_mashkif.SportApp;
using c_sharp_apps_izhar_mashkif.TransportationApp;
using c_sharp_apps_izhar_mashkif.MyDataApp;
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
            int choose = 0;
            do
            {
                Console.WriteLine("Choose one options: ");
                Console.WriteLine("1 – Bank App | 2 – Sport App | 3 – Transportation App " +
                    "4 – Draft App |" +
                    "| 5 – MyData App |"
                   + " 0- Exit");

                choose = int.Parse(Console.ReadLine());
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
                        case 5:
                            MyDataAppMain.MainEntry();
                            break;
                    }

                   

                }
            }
            while (choose != 0);
            
        }
    }
}
