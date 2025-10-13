using Tyuiu.MolkovIS.Sprint3.Task2.V20.Lib;


namespace Tyuiu.MolkovIS.Sprint3.Task2.V20.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            double wait = 914700.940;
            var dataService = new DataService();
            double real = dataService.GetMultiplySeries(1, 1, 6);
            Assert.AreEqual(wait, real);
        }
    }
}
