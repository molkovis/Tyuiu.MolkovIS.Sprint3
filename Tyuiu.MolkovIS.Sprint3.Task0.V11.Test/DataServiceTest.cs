using Tyuiu.MolkovIS.Sprint3.Task0.V11.Lib;

namespace Tyuiu.MolkovIS.Sprint3.Task0.V11.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int value = 5;
            int start = 1;
            int end = 10;

            double wait = 0.042;

            DataService service = new DataService();

            double real = service.GetSumSeries(value, start, end);

            Assert.AreEqual(wait, real);

        }
    }
}
