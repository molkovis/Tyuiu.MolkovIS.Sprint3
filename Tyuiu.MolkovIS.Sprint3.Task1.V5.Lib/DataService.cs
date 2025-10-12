using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolkovIS.Sprint3.Task1.V5.Lib
{
    public class DataService : ISprint3Task1V5
    {
        public double GetMultiplySeries(int startValue, int stopValue)
        {
            double res = 1;
            double cosConst = Math.Cos(0.1);
            while (startValue <= stopValue)
            {
                res = res * (cosConst + Math.Pow(startValue, -2));
                startValue++;
            }
            return Math.Round(res, 3);
        }
    }
}
