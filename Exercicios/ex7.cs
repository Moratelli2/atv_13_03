internal class ex6
{
    private static void Main(string[] args)
    {
        int f = 1, n;

        Console.WriteLine("digite o numero a ser fatorado: ");
        n = int.Parse(Console.ReadLine());

        while (n != 1)
        {
            if (n == 0)
            {
                f = 1;
                break;
            }

            f = f * n;
            n--;
            if (n < 0)
            {
                Console.WriteLine("digite um valor positivo.");
                n = int.Parse(Console.ReadLine());

            }
            //else
            //    if (n == 0)
            //    {
            //        f = 1;
            //    }

        }
        Console.WriteLine("o fatorial é {0}", f);
        Console.ReadKey();
    }

}
