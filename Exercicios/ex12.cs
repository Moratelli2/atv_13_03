internal class ex11
{
    private static void Main(string[] args)
    {
        //Crie um programa que exiba na tela os números pares de 0 a 20

        for (int i = 1; i <= 20;  i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

}
