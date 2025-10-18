using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MolkovIS.Sprint3.Task7.V13.Lib
{
    public class DataService : ISprint3Task7V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result = new double[stopValue-startValue+1];
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                double delit = Math.Cos(x) + 1;
                if (delit == 0)
                {
                    result[count] = 0;
                    continue;
                }
                result[count] = Math.Round(3*x + 2 - (2*x-x)/(delit),2);
                count++;
            }
            return result;
        }
    }
}
