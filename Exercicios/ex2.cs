internal partial class Ex2
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num3 % 2 == 0)
        {
            Console.WriteLine("Esse numero é PAR");
        }
        else
        {
            Console.WriteLine("Esse numero é IMPAR");
        }
    }
}