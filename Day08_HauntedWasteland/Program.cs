namespace Day08_HauntedWasteland;

public static class Program
{
    public static void Main()
    {
        const string path = "LLRRRLRLLRRLLRLRLRLRRLRRRLRRRLRLRRLLRLLRRRLRRLRRRLRLRRRLRRLRLRRRLRRRLRRLRLRRRLRRLRRLRRRLRLRLLRLLRLLRLRRRLRRLRRLRRRLRLRRRLRLRLRLRRRLRRRLRLRLRLRRRLRLLRRLLRLLRRLRRRLLRRRLLRRLRLRRLRLLRLLLLRRLLRRLRRLRLLLRRRLRRLRRRLRRLLRLRRRLRLLRRRLLLLRLRRRLRLRRLRRLRRLLRLRLRRLLLRRLLRLRRLRRRR";
        
        const string file = "data.txt";
        var lines = File.ReadAllLines(file);
        
        var result = Worker.FindZZZ(lines, path);
        Console.WriteLine(result);
    }
}