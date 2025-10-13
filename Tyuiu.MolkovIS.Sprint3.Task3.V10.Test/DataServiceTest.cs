using Tyuiu.MolkovIS.Sprint3.Task3.V10.Lib;

namespace Tyuiu.MolkovIS.Sprint3.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "gdfppf vfppt p";
            string wait = "gdff vft ";
            DataService dataService = new DataService();
            char p = 'p';
            string real = dataService.DeleteCharInString(input, p);
        }
    }
}
