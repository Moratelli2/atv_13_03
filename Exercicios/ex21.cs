internal class ex16
{
    private static void Main(string[] args)
    {

        Console.Write("Escolha um número: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            int a = 1;
            int b = 0;
            int c = 0;

            for (int i = 0; i < number; i++)
            {
                c = a + b;
                if (c > number)
                    break;
                Console.Write($"{c} ");
                a = b;
                b = c;
            }
        }

    }

}
