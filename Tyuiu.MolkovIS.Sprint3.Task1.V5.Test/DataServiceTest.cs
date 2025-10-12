using Tyuiu.MolkovIS.Sprint3.Task1.V5.Lib;

namespace Tyuiu.MolkovIS.Sprint3.Task1.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double wait = 3.195;
            double real = ds.GetMultiplySeries(1, 10);
            Assert.AreEqual(wait, real);
        }
    }
}