namespace _03_GearRatios;

public static class Program
{
    public static void Main()
    {
        const string file = "test.txt";
        var lines = File.ReadAllLines(file);
        
        var result = SchematicParser.CalculatePartNumbersSum(lines);
    }
}