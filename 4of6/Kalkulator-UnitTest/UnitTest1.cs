using Calculator_UnitTest;

namespace Kalkulator_UnitTest
{
    public class Tests
    {
        [Test]
        public void TestAddisjon()
        {
            Kalkulator kalkulator = new Kalkulator();
            int result = kalkulator.LeggSammen(2, 2);
            int result2 = kalkulator.LeggSammen(-2, 2);
            int result3 = kalkulator.LeggSammen(0, 2);
            int result4 = kalkulator.LeggSammen(2, 0);
            Assert.AreEqual(4, result);
            Assert.AreEqual(0, result2);
            Assert.AreEqual(2, result3);
            Assert.AreEqual(2, result4);
        }

        [Test]
        public void TestSubstraksjon()
        {
            Kalkulator kalkulator = new Kalkulator();
            int result = kalkulator.TrekkFra(2, 2);
            int result2 = kalkulator.TrekkFra(-2, 2);
            int result3 = kalkulator.TrekkFra(0, 2);
            int result4 = kalkulator.TrekkFra(2, 0);
            Assert.AreEqual(0, result);
            Assert.AreEqual(-4, result2);
            Assert.AreEqual(-2, result3);
            Assert.AreEqual(2, result4);
        }

        [Test]
        public void TestMultiplikasjon()
        {
            Kalkulator kalkulator = new Kalkulator();
            int result = kalkulator.Multipliser(2, 2);
            int result2 = kalkulator.Multipliser(-2, 2);
            int result3 = kalkulator.Multipliser(0, 2);
            int result4 = kalkulator.Multipliser(2, 0);
            Assert.AreEqual(4, result);
            Assert.AreEqual(-4, result2);
            Assert.AreEqual(0, result3);
            Assert.AreEqual(0, result4);
        }

        [Test]
        public void TestDivisjon()
        {
            int result;
            Kalkulator kalkulator = new Kalkulator();

            result = kalkulator.Divider(2, 2);
            Assert.AreEqual(1, result);
            result = kalkulator.Divider(-2, 2);
            Assert.AreEqual(-1, result);
            result = kalkulator.Divider(0, 2);
            Assert.AreEqual(0, result);

            //result = kalkulator.Divider(2, 0);
            Assert.Throws<ArgumentException>(() => kalkulator.Divider(2, 0));
        }
    }
}