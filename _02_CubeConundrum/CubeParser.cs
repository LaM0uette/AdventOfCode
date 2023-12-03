using System.Text.RegularExpressions;

namespace _02_CubeConundrum;

public struct Cubes(int red, int green, int blue)
{
    public int Red { get; set; } = red;
    public int Green { get; set; } = green;
    public int Blue { get; set; } = blue;
}

public struct Subset(Cubes cubes)
{
    public Cubes Cubes { get; set; } = cubes;
}

public struct Game(int id)
{
    public int Id { get; } = id;
    public List<Subset> Subsets { get; } = [];
}

public class CubeParser(int maxCubeRed, int maxCubeGreen, int maxCubeBlue)
{
    #region Statements

    private int MaxCubeRed { get; } = maxCubeRed; // 12
    private int MaxCubeGreen { get; } = maxCubeGreen; // 13
    private int MaxCubeBlue { get; } = maxCubeBlue; // 14

    #endregion

    #region Functions
    
    public static Game ParseLine(string line)
    {
        var gameId = ParseGameId(line);
        var game = new Game(gameId);
        
        line = line.Replace($"Game {gameId}: ", "");
        
        var subsets = line.Split("; ");

        foreach (var subset in subsets)
        {
            game.Subsets.Add(ParseSubset(subset));
        }

        return game;
    }
    
    public bool GameIsValid(Game game)
    {
        var result = false;
        foreach (var subset in game.Subsets)
        {
            result = SubsetIsValid(subset.Cubes.Red, subset.Cubes.Green, subset.Cubes.Blue);
            
            if (!result) break;
        }

        return result;
    }

    public bool SubsetIsValid(int red, int green, int blue)
    {
        return red <= MaxCubeRed && green <= MaxCubeGreen && blue <= MaxCubeBlue;
    }

    #endregion

    #region Parsers

    public static int ParseGameId(string line)
    {
        const string pattern = @"(?<=Game )\d*";

        var match = Regex.Match(line, pattern);
        return int.Parse(match.Value);
    }
    
    public static Subset ParseSubset(string line)
    {
        const string patternRed = @"\d+(?= red)";
        const string patternGreen = @"\d+(?= green)";
        const string patternBlue = @"\d+(?= blue)";
        
        var cubes = new Cubes
        {
            Red = ParseCubes(line, patternRed),
            Green = ParseCubes(line, patternGreen),
            Blue = ParseCubes(line, patternBlue)
        };

        return new Subset(cubes);
    }
    
    public static int ParseCubes(string line, string pattern)
    {
        var match = Regex.Match(line, pattern);
        return !match.Success ? 0 : int.Parse(match.Value);
    }

    #endregion
}