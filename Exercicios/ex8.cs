internal class ex8
{
    //Faça um programa que leia uma string e informe quantas vezes uma determinada letra aparece na string.
    private static void Main(string[] args)
    {
        //int count = source.Count(x => x == 'A');
        Console.WriteLine("Digite uma palavra: ");
        string palavra = Console.ReadLine();

        Console.WriteLine("Digite uma letra que deseja verificar: ");
        char letra = char.Parse(Console.ReadLine());

        int count = palavra.Count(x => x == letra);

        Console.WriteLine("A letra {0} aparece {1} vezes", letra, count);
    }

}
