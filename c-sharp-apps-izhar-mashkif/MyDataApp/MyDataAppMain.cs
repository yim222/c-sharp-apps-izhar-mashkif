using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.BankApp;
using c_sharp_apps_izhar_mashkif.SportApp;
namespace c_sharp_apps_izhar_mashkif.MyDataApp
{
    public class MyDataAppMain
    {

        public static void MainEntry()
        {
            Console.WriteLine("MyDataApp");


            string firstName = "Abraham";
            string lastName = "Israel";

            Owner owner1 = new Owner(firstName, lastName);

            Account account1 = new Account(owner1, 20_000, 15_000);

            GeneralPlayer g1 = new GeneralPlayer("Messy", "Goal");

            InterfaceData[] mydata = new InterfaceData[2];
            mydata[0] = account1;
            mydata[1] = g1;

            for(int i =0; i< mydata.Length; i++)
            {
                Console.WriteLine("data " + i + " = " +mydata[i].GenerateData());

                mydata[i].Do1();
            }


        }
    }
}
