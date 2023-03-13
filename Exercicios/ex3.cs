internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite o num1: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o num2: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o num3: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("Num1 é o maior");
        }
        if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("Num2 é o maior");
        }
        if (num3 > num1 && num3 > num2)
        {
            Console.WriteLine("Num3 é o maior");
        }
    }
}
