internal class ex6
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero Inteiro: ");
        int numInt = int.Parse(Console.ReadLine());

        if (numInt > 0)
        {
            Console.WriteLine("Numero Positivo");
        }
        if (numInt < 0)
        {
            Console.WriteLine("Numero Negativo");

        }
        if(numInt == 0)
        {
            Console.WriteLine("Numero Igual a 0");
        }
    }

}
