internal class ex13
{
    private static void Main(string[] args)
    {
        //18-Crie um programa que solicite ao usuário uma frase e exiba na tela quantas vezes cada letra aparece na frase.

        Console.WriteLine("Digite uma frase: ");
        string frase = Console.ReadLine();

        for (int i = 0; i <= frase.Count(); i++)
        {
            int countLetras = frase.Count(x => x == frase);
            Console.WriteLine("A letra {0} aparece {1} vezes", frase[i], countLetras);
        }

    }

}
