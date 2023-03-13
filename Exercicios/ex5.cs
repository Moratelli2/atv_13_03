internal class ex5
{
    private static void Main(string[] args)
    {
        List<int> listNumber = new List<int>();
        Console.WriteLine("Digite a quantidade de numeros: ");
        int numCount = int.Parse(Console.ReadLine());

        for (int i = 1; i <= numCount; i++) {

            Console.WriteLine("Digite um numero: ");
            int numMedia = int.Parse(Console.ReadLine());

            listNumber.Add(numMedia);
        }

        Console.WriteLine(listNumber.Average());


    }
}
