using Tyuiu.MolkovIS.Sprint3.Task3.V10.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        DataService dataService = new DataService();
        Console.Write("Введите строку: "); string value = Console.ReadLine();
        Console.Write("Введите символ: "); char item = Convert.ToChar(Console.ReadLine());

        string res = dataService.DeleteCharInString(value, item);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}