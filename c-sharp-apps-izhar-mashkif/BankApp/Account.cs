using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.BankApp
{
    public class Account
    {

        private Owner owner = null;

        private double balance = 0;

        private const int maxOverDraft = 90_000;

        private int overDraft = 0;

        public Account(Owner owner, double balance, int overDraft)
        {
            this.owner = owner;
            this.balance = balance;
            this.overDraft = overDraft;
        }




         //getters
        public Owner GetOwner()
        {
            return owner;
        }
        public double GetBalance() { return balance; }

        public int GetOverDraft() { return overDraft; }




        //max overdraft 90,000

        public void SetOverdraft(int overdraft)
        {
            if(overdraft > maxOverDraft)
            {
                Console.WriteLine("You cannot do overdraft more than " + maxOverDraft);
            }
            this.overDraft = overdraft;
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }

        public void Withdraw(double amount)
        {
            if(this.balance - amount < -overDraft)
            {
                Console.WriteLine("You cannot exceed the overdraft  " );
            }
            this.balance -= amount;
        }

        public override string ToString()
        {
            return $"Owner = {owner.GetFirstName()} {owner.GetLastName}\n" +
                $"balance = {balance}";
        }

    }
}
