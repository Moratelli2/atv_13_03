internal class ex4
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Digite um numero: ");
        int num1 = int.Parse(Console.ReadLine());
        int divisores = 0;

        for (int i = 1; i <= num1; i++)
        {


            if (num1 % i == 0)
            {

                divisores++;


            }

           
        }
        if (divisores == 2)
        {
            Console.WriteLine("é numero primo");
        }
        else
        {
            Console.WriteLine("não é primo");
        }

    }
}
