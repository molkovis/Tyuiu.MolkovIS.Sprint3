using Tyuiu.MolkovIS.Sprint3.Task4.V12.Lib;

namespace Tyuiu.MolkovIS.Sprint3.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            
            double wait = 467.590;
            double real = dataService.Calculate(-5, 5);
            Assert.AreEqual(wait, real);

        }
    }
}
