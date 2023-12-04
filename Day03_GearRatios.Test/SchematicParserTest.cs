namespace Day03_GearRatios.Test;

public class SchematicParserTest
{
    [Fact]
    public void CalculatePartNumbersSum_Demo_4361()
    {
        // Arrange
        var schematic = new[]
        {
            "467..114..",
            "...*......",
            "..35..633.",
            "......#...",
            "617*......",
            ".....+.58.",
            "..592.....",
            "......755.",
            "...$.*....",
            ".664.598..",
        };
        
        // Act
        var result = SchematicParser.CalculatePartNumbersSum(schematic);
        
        // Assert
        Assert.Equal(4361, result);
    }
}