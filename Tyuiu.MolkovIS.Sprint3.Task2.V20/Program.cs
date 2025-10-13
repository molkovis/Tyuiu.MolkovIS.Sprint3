using Tyuiu.MolkovIS.Sprint3.Task2.V20.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.Write("Введите x: "); int value = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите начало: "); int start = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите конец: "); int end = Convert.ToInt32(Console.ReadLine());
        double res = dataService.GetMultiplySeries(value, start, end);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}