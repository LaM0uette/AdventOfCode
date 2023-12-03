namespace _02_CubeConundrum;

public static class Program
{
    public static void Main()
    {
        const string file = "data.txt";
        var lines = File.ReadAllLines(file);
        
        var parser = new CubeParser(12, 13, 14);
        
        var result = parser.GetSumOfValidGames(lines);
        Console.WriteLine(result);
    }
}