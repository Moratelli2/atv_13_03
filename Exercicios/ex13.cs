internal class ex12
{
    private static void Main(string[] args)
    {
        //Crie um programa que solicite ao usuário um número e exiba na tela a tabuada desse número, de 1 a 10

        Console.WriteLine("Digite um numero: ");
        int numUser = int.Parse(Console.ReadLine());


        for (int i = 1; i <= 10;  i++)
        {
            Console.WriteLine("{0} x {1} = {2}",numUser, i, (numUser*i));
        }
    }

}
