using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolkovIS.Sprint3.Task2.V20.Lib
{
    public class DataService : ISprint3Task2V20
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double result = 1;
            double Condition = 2.0/(Math.Cos(value) + 0.5);
            do
            {
                result = result * Math.Pow(Condition, startValue++);
            } while (startValue <= stopValue);
            return Math.Round(result,3);
        }
    }
}
