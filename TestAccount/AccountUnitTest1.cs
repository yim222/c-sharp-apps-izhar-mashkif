using c_sharp_apps_izhar_mashkif.BankApp;

namespace TestAccount
{
    [TestClass]
    public class AccountUnitTest1
    {
        [TestMethod]
        public void TestNotNegativeOverDraft()
        {
            string firstName = "Abraham";
            string lastName = "Israel";

            Owner owner1 = new Owner(firstName, lastName);

            int overDraft = 15_000;

            Account account1 = new Account(owner1, 20_000, overDraft);

            account1.SetOverdraft(-20_000);

            int expected = overDraft;

            Assert.AreEqual(expected, account1.GetOverDraft(), 
                "\nNegative Overdraft should not be allowed");


        }
        [TestMethod]
        public void TestOwnerLastNameByConstructor()
        {
            string firstName = "Abraham";
            string lastName = "Cohen";

            Owner owner1 = new Owner(firstName, lastName);

            Assert.AreEqual("Cohen", owner1.GetLastName());

        }


        [TestMethod]
        public void TestOwnerFirstNameByConstructor()
        {
            string firstName = "Abraham";
            string lastName = "Cohen";

            Owner owner1 = new Owner(firstName, lastName);

            Assert.AreEqual("Abraham", owner1.GetFirstName());

        }

    }
}