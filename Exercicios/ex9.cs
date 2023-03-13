internal class ex8
{
    private static void Main(string[] args)
    {
        int soma = 0;
        Console.WriteLine("digite um numero inteiro");
        int numero = int.Parse(Console.ReadLine());
        int n = numero;

        for (int i = 1; i < numero; i++)
        {
            if (numero % i == 0)
            {
                soma = soma + i;
            }
        }
        if (soma == n)
        {
            Console.WriteLine("{0} eh perfeito\n", numero);
        }
        else
        {
            Console.WriteLine("{0} nao eh perfeito\n", numero);
        }




    }

}
