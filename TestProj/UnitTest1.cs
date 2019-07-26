using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProj
{
    [TestClass]
    public class �͹�ԹTest
    {
        [TestMethod]
        public void Test�͹�Թ55�ҷầ��50_1���5�ҷ1����­()
        {
            Money money = new Money();
            money.Bank50 = 1;
            money.Coin5 = 1;

            Calculate cal = new Calculate();

            Money actualMoney = cal.Change(55);

            Assert.AreEqual(money.ToString(), actualMoney.ToString());
        }

        [TestMethod]
        public void Test�͹�Թ70�ҷầ��50_1����ầ��20�()
        {
            Money money = new Money();
            money.Bank50 = 1;
            money.Bank20 = 1;

            Calculate cal = new Calculate();

            Money actualMoney = cal.Change(70);

            Assert.AreEqual(money.ToString(), actualMoney.ToString());
        }

        [TestMethod]
        public void Test�͹�Թ339�ҷầ��100_3����ầ��20_1�����­10_1����­_����­5_1����­_����­2�ҷ_2����­()
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
        public void Test�͹�Թ677�ҷầ��500_1����ầ��100_1����ầ��50_1����ầ��20_1�����­5_1����­_����­2�ҷ_1����­()
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
