internal class ex9
{
    private static void Main(string[] args)
    {
        List<int> listNumber = new List<int>();
        while (true)
        {
            
            Console.WriteLine("Digite um numero: ");
            int numUser = int.Parse(Console.ReadLine());
            if (numUser == 0)
            {
                Console.WriteLine("============");
                break;
            }
            listNumber.Add(numUser);    

            

        }
        
        listNumber.Remove(listNumber.Max(x => x));
        Console.WriteLine("O segundo valor maior é {0}",listNumber.Max(x => x));
    }

}
