using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.electric_device
{
    public class GameConsole:ElectricProduct
    {
        private int gb;

        public GameConsole()
        {

        }

        public GameConsole(int gb):base("name",0,0,0,0)
        {
            this.gb = gb;
        }
        public  void  SetMaxWatt(int watt)
        {
            if(watt>250)
            this.watt=watt;
        }

        public void DisplayGameConsole()
        {
            DisplayD();
            Console.WriteLine("gb is " + gb);
        }
    }
}
