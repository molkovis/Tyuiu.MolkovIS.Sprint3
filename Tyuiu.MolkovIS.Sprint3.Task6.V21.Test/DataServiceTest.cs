using Tyuiu.MolkovIS.Sprint3.Task6.V21.Lib;

namespace Tyuiu.MolkovIS.Sprint3.Task6.V21.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService dataService = new DataService();
            int start = 4;
            int stop = 14;
            int wait = 157;
            int real = dataService.GetSumTheDivisors(start, stop);
            Assert.AreEqual(wait, real);

        }
    }
}
