using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProj
{
    [TestClass]
    public class PaymentTest
    {
        [TestMethod]
        public void เกิน_4_ทุ่มชำระเงินไม่ได้ ()
        {
            bool expectedResult = false;
            StubTime myTime = new StubTime(22,0,0);
            Payment payment = new Payment(myTime);
            bool actualResult = payment.pay(500);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void เกิน_4_ทุ่ม_30_วินาทีชำระเงินไม่ได้()
        {
            bool expectedResult = false;
            StubTime myTime = new StubTime(22,0,30);
            Payment payment = new Payment(myTime);
            bool actualResult = payment.pay(500);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void ไม่เกิน_4_ทุ่ม_ชำระเงินได้()
        {
            bool expectedResult = true;
            StubTime myTime = new StubTime(21, 0, 30);
            Payment payment = new Payment(myTime);
            bool actualResult = payment.pay(500);
            Assert.AreEqual(expectedResult, actualResult);
        }

    }
}
