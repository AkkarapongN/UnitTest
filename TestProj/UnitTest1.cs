using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProj
{
    [TestClass]
    public class ทอนเงินTest
    {
        [TestMethod]
        public void Testทอนเงิน55บาทแบงค์50_1และ5บาท1เหรียญ()
        {
            Money money = new Money();
            money.Bank50 = 1;
            money.Coin5 = 1;

            Calculate cal = new Calculate();

            Money actualMoney = cal.Change(55);

            Assert.AreEqual(money.ToString(), actualMoney.ToString());
        }

        [TestMethod]
        public void Testทอนเงิน70บาทแบงค์50_1ใบและแบงค์20ใบ()
        {
            Money money = new Money();
            money.Bank50 = 1;
            money.Bank20 = 1;

            Calculate cal = new Calculate();

            Money actualMoney = cal.Change(70);

            Assert.AreEqual(money.ToString(), actualMoney.ToString());
        }

        [TestMethod]
        public void Testทอนเงิน339บาทแบงค์100_3ใบและแบงค์20_1ใบเหรียญ10_1เหรียญ_เหรียญ5_1เหรียญ_เหรียญ2บาท_2เหรียญ()
        {
            Money money = new Money();
            money.Bank100 = 3;
            money.Bank20 = 1;
            money.Coin10 = 1;
            money.Coin5 = 1;
            money.Coin2 = 2;

            Calculate cal = new Calculate();

            Money actualMoney = cal.Change(339);

            Assert.AreEqual(money.ToString(), actualMoney.ToString());
        }

        [TestMethod]
        public void Testทอนเงิน677บาทแบงค์500_1ใบและแบงค์100_1ใบและแบงค์50_1ใบและแบงค์20_1ใบเหรียญ5_1เหรียญ_เหรียญ2บาท_1เหรียญ()
        {
            Money money = new Money();
            money.Bank500 = 1;
            money.Bank100 = 1;
            money.Bank50 = 1;
            money.Bank20 = 1;
            money.Coin5 = 1;
            money.Coin2 = 1;

            Calculate cal = new Calculate();

            Money actualMoney = cal.Change(677);

            Assert.AreEqual(money.ToString(), actualMoney.ToString());
        }
    }
}
