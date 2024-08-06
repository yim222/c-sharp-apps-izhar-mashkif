using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.electric_device;
using c_sharp_apps_izhar_mashkif.products;
using c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public class TransportationAppMain
    {
        public static void MainEntry()
        { 
            Console.WriteLine("TransportationApp");
           TestCargoApp();
            //some test for items... 



            Console.WriteLine("\n***************\n");



        }

        public static void TestCargoApp()
        {
            Console.WriteLine("Test cargo app");
            PC pc = new PC("Asus ROG");

            Console.WriteLine("pc= " + pc);
            GeneralProduct myProduct = new GeneralProduct();


            //test if port load and unload items
            Port port = new Port();

            //Print list
            Console.WriteLine("port list 1= ", string.Join("|", port.Items));

            port.Load(pc);
            foreach (var item in port.Items)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("port list 2= ", string.Join("|", port.Items[0]));

            
            
            port.Load(myProduct);
            Console.WriteLine("port list 3 = ", string.Join("|", port.Items));

            foreach (var item in port.Items)
            {
              
                Console.WriteLine(item.ToString());
            }

            port.Unload(pc);
            Console.WriteLine("port list 4 = ", string.Join("|", port.Items));
            foreach (var item in port.Items)
            {
                
                Console.WriteLine(item.ToString());
            }
            port.Unload(myProduct);
            Console.WriteLine("port list 5= ", string.Join("|", port.Items));
            foreach (var item in port.Items)
            {
                Console.WriteLine(item.ToString());
            }



        }
    }
}
