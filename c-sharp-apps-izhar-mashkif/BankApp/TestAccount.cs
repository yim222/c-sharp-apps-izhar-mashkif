using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.BankApp
{
    public class TestAccount
    {

        public static void Test1()
        {
            Console.WriteLine("Test Account - Test 1");



            string firstName = "Abraham";
            string lastName = "Israel";

            Owner owner1 = new Owner(firstName, lastName);

            Account account1 = new Account(owner1, 20_000, 15_000);

            Console.WriteLine("Testing owner creation");

            bool allPassed = true;
            if (account1.GetOwner().GetFirstName().Equals(firstName))
            {
                Console.WriteLine("Test 1 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at owner first name at accout. expected = " + firstName
                    + "| actual = " + account1.GetOwner().GetFirstName());
            }

            if (account1.GetOwner().GetLastName().Equals(lastName))
            {
                Console.WriteLine("Test 2 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at owner last name at accout. expected = " + lastName
                    + "| actual = " + account1.GetOwner().GetLastName());
            }

            Console.WriteLine("Testing Deposit");

            account1.Deposit(1570);

            if (account1.GetBalance() == 21570)
            {
                Console.WriteLine("Test 3 - passed");
            }
            else
            {
                Console.WriteLine("Error at deposit in account. expected = " + 21570
                    + "| actual = " + account1.GetBalance());
            }

            //Testing another instance 

            firstName = "Moshe";
            lastName = "Faith";

            Owner owner2 = new Owner(firstName, lastName);

            Account account2 = new Account(owner2, 240, 5000);

            Console.WriteLine("Testing owner creation");
            if (account2.GetOwner().GetFirstName().Equals(firstName))
            {
                Console.WriteLine("Test 4 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at owner first name at accout. expected = " + firstName
                    + "| actual = " + account2.GetOwner().GetFirstName());
            }

            if (account2.GetOwner().GetLastName().Equals(lastName))
            {
                Console.WriteLine("Test 5 - passed");
            }
            else
            {
                Console.Error.WriteLine("Error at owner last name at accout. expected = " + lastName
                    + "| actual = " + account2.GetOwner().GetLastName());
            }

            Console.WriteLine("Testing Deposit");

            account2.Deposit(645);

            if (account2.GetBalance() == 240 + 645)
            {
                Console.WriteLine("Test 7 - passed");
            }
            else
            {
                Console.WriteLine("Error at deposit in account. expected = " + (240 + 645)
                    + "| actual = " + account2.GetBalance());
            }

            //test withdraw
            account2.Withdraw(100);


            if (account2.GetBalance() == 785)
            {
                Console.WriteLine("Test 8 - passed");
            }
            else
            {
                Console.WriteLine("Error at Withdraw in account. expected = " + 785
                    + "| actual = " + account2.GetBalance());
            }

            //testOverDraft

            account2.Withdraw(7000);
            if (account2.GetBalance() == 785)
            {
                Console.WriteLine("Test 9 - passed");
            }
            else
            {
                Console.WriteLine("Error at testOverDraft in account. expected = " + 785
                    + "| actual = " + account2.GetBalance());
            }


            //test maxOverdraft
            account2.SetOverdraft(100_000);

            if (account2.GetOverDraft() == 5002)
            {
                Console.WriteLine("Test 10 - passed");
            }
            else
            {
                Console.WriteLine("Error at testOverDraft in account. expected = " + 5000
                    + "| actual = " + account2.GetBalance());
            }





        }
    }
}
