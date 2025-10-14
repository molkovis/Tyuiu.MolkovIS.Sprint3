using Tyuiu.MolkovIS.Sprint3.Task5.V15.Lib;

namespace Tyuiu.MolkovIS.Sprint3.Task5.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService data = new DataService();
            double wait = 548.732;
            double real = data.GetSumSumSeries(5,1,3,1,10);
            Assert.AreEqual(wait,real);
        }
    }
}
