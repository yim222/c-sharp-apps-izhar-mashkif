using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.MyDataApp;

namespace c_sharp_apps_izhar_mashkif.BankApp
{
    public class Owner
    {

        private string firstName;

        private string lastName;

        private int branch;//סניף

        private int accountNum;//מס חשבון

        public Owner(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
           
        }

        public string GetFirstName()
        {
            return firstName;
        }
        public string GetLastName()
        {
            return lastName;
        }
    }
}
