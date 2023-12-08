namespace Day08_HauntedWasteland;

public struct Element(string name, string left, string right)
{
    public string Name { get; set; } = name;
    public string Left { get; set; } = left;
    public string Right { get; set; } = right;
}