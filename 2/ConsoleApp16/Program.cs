internal class Program
{
    static void Main()
    {
        Console.WriteLine("Тут массив захардкожен:");

        MinMax.MinMaxv1 v1 = new MinMax.MinMaxv1();
        int[] numbers1 = v1.GetNumbers();
        Console.WriteLine($"Min: {v1.Min(numbers1)}, Max: {v1.Max(numbers1)}");

        Console.WriteLine();

        Console.WriteLine("Тут вводим массив вручную:");

        MinMax.MinMaxv2 v2 = new MinMax.MinMaxv2();
        int[] numbers2 = v2.GetNumbers();
        Console.WriteLine($"Min: {v2.Min(numbers2)}, Max: {v2.Max(numbers2)}");
    
        Console.ReadLine();
    }
}