using Tyuiu.MolkovIs.Sprint3.Task1.V5.Lib;

namespace Tyuiu.MolkovIs.Sprint3.Task1.V5.Test
{
    [TestClass]
    public sealed class DSTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DS ds = new DS();
            double wait = 3.195;
            double real = ds.GetMultiplySeries(1, 10);
            Assert.AreEqual(wait, real);
        }
    }
}
