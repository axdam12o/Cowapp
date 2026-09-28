namespace Kuhbsp;

class Program
{
    static void Main(string[] args)
    {
        List<Cow> cows = new List<Cow>
        {
            new Cow("Berta", "Braun", 5, true, 650),
            new Cow("Lotte", "Weiß", 3, false, 500),
            new Cow("Mimi", "Schwarz", 7, true, 700),
            new Cow("Susi", "Braun", 4, false, 550)
        };
        
        Console.WriteLine("Nach Gewicht:");
        cows.Sort(new CompareByWeight());

        foreach (Cow cow in cows)
            Console.WriteLine(cow);

        Console.WriteLine();

        Console.WriteLine("Nach Coolness:");
        cows.Sort(new CompareByCoolness());

        foreach (Cow cow in cows)
            Console.WriteLine(cow);

        Console.WriteLine();

        Console.WriteLine("Nach Farbe:");
        cows.Sort(new CompareByColor());

        foreach (Cow cow in cows)
            Console.WriteLine(cow);

        Console.WriteLine();

        Console.WriteLine("Nach Alter:");
        cows.Sort(new CombareByAge());

        foreach (Cow cow in cows)
            Console.WriteLine(cow);
        
        
        
    }
}