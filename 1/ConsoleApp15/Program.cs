
namespace ezu_201_gubskaya
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Тут массив захардкожен:");
            new MinMax.MinMax_v1().Run();

            Console.WriteLine();
            Console.WriteLine("Тут вводим массив вручную:");
            new MinMax.MinMax_v2().Run();

            Console.ReadLine();
        }
    }
}