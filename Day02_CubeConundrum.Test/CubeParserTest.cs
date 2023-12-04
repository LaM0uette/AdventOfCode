namespace Day02_CubeConundrum.Test;

public class CubeParserTest
{
    #region Subsets

    [Fact]
    public void SubsetIsValid_Demo1_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);

        // Act
        var t1 = parser.SubsetIsValid(4, 0, 3);
        var t2 = parser.SubsetIsValid(1, 2, 6);
        var t3 = parser.SubsetIsValid(0, 2, 0);

        // Assert
        Assert.True(t1 && t2 && t3);
    }
    
    [Fact]
    public void SubsetIsValid_Demo2_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);

        // Act
        var t1 = parser.SubsetIsValid(1, 2, 0);
        var t2 = parser.SubsetIsValid(1, 3, 4);
        var t3 = parser.SubsetIsValid(0, 1, 1);

        // Assert
        Assert.True(t1 && t2 && t3);
    }
    
    [Fact]
    public void SubsetIsValid_Demo3_False()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);

        // Act
        var t1 = parser.SubsetIsValid(20, 8, 6);
        var t2 = parser.SubsetIsValid(4, 13, 5);
        var t3 = parser.SubsetIsValid(1, 5, 0);

        // Assert
        Assert.False(t1 && t2 && t3);
    }
    
    [Fact]
    public void SubsetIsValid_Demo4_False()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);

        // Act
        var t1 = parser.SubsetIsValid(3, 1, 6);
        var t2 = parser.SubsetIsValid(6, 3, 0);
        var t3 = parser.SubsetIsValid(14, 3, 15);

        // Assert
        Assert.False(t1 && t2 && t3);
    }
    
    [Fact]
    public void SubsetIsValid_Demo5_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);

        // Act
        var t1 = parser.SubsetIsValid(6, 3, 1);
        var t2 = parser.SubsetIsValid(1, 2, 2);

        // Assert
        Assert.True(t1 && t2);
    }

    #endregion

    #region Parsers
    
    [Fact]
    public void ParseGameId_Game1_1()
    {
        // Arrange
        const string input = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

        // Act
        var game = CubeParser.ParseGameId(input);

        // Assert
        Assert.Equal(1, game);
    }
    
    [Fact]
    public void ParseGameId_Game45_45()
    {
        // Arrange
        const string input = "Game 45: 3 blue, 6 green, 1 red; 4 green, 3 blue; 8 green, 3 blue";

        // Act
        var game = CubeParser.ParseGameId(input);

        // Assert
        Assert.Equal(45, game);
    }
    
    [Fact]
    public void ParseGameId_Game100_100()
    {
        // Arrange
        const string input = "Game 100: 5 green, 11 blue, 6 red; 5 green, 12 blue; 1 green, 14 blue, 1 red; 3 blue, 5 red, 6 green; 9 blue; 6 red";

        // Act
        var game = CubeParser.ParseGameId(input);

        // Assert
        Assert.Equal(100, game);
    }
    
    [Fact]
    public void ParseCubes_6Red_6()
    {
        // Arrange
        const string input = "Game 100: 5 green, 11 blue, 6 red";

        // Act
        var i1 = CubeParser.ParseCubes(input, @"\d+(?= red)");
        var i2 = CubeParser.ParseCubes(input, @"\d+(?= green)");
        var i3 = CubeParser.ParseCubes(input, @"\d+(?= blue)");

        // Assert
        Assert.Equal(6, i1);
        Assert.Equal(5, i2);
        Assert.Equal(11, i3);
    }
    
    [Fact]
    public void ParseSubset_Demo1_True()
    {
        // Arrange
        const string line = "3 blue, 4 red";

        // Act
        var result = CubeParser.ParseSubset(line);

        // Assert
        Assert.Equal(4, result.Cubes.Red);
        Assert.Equal(3, result.Cubes.Blue);
        Assert.Equal(0, result.Cubes.Green);
    }

    [Fact]
    public void ParseLine_Demo1_True()
    {
        // Arrange
        const string input = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.True(game.Id == 1);
        Assert.True(game.Subsets.Count == 3);
        
        Assert.True(game.Subsets[0].Cubes.Red == 4);
        Assert.True(game.Subsets[0].Cubes.Green == 0);
        Assert.True(game.Subsets[0].Cubes.Blue == 3);
        
        Assert.True(game.Subsets[1].Cubes.Red == 1);
        Assert.True(game.Subsets[1].Cubes.Green == 2);
        Assert.True(game.Subsets[1].Cubes.Blue == 6);
        Assert.True(game.Subsets[2].Cubes.Red == 0);
        Assert.True(game.Subsets[2].Cubes.Green == 2);
        Assert.True(game.Subsets[2].Cubes.Blue == 0);
    }
    
    [Fact]
    public void ParseLine_Demo3_True()
    {
        // Arrange
        const string input = "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.True(game.Id == 3);
        Assert.True(game.Subsets.Count == 3);
        
        Assert.True(game.Subsets[0].Cubes.Red == 20);
        Assert.True(game.Subsets[0].Cubes.Green == 8);
        Assert.True(game.Subsets[0].Cubes.Blue == 6);
        
        Assert.True(game.Subsets[1].Cubes.Red == 4);
        Assert.True(game.Subsets[1].Cubes.Green == 13);
        Assert.True(game.Subsets[1].Cubes.Blue == 5);
        
        Assert.True(game.Subsets[2].Cubes.Red == 1);
        Assert.True(game.Subsets[2].Cubes.Green == 5);
        Assert.True(game.Subsets[2].Cubes.Blue == 0);
    }
    
    [Fact]
    public void ParseLine_Game100_True()
    {
        // Arrange
        const string input = "Game 100: 5 green, 11 blue, 6 red; 5 green, 12 blue; 1 green, 14 blue, 1 red; 3 blue, 5 red, 6 green; 9 blue; 6 red";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.True(game.Id == 100);
        Assert.True(game.Subsets.Count == 6);
        
        Assert.True(game.Subsets[0].Cubes.Red == 6);
        Assert.True(game.Subsets[0].Cubes.Green == 5);
        Assert.True(game.Subsets[0].Cubes.Blue == 11);
        
        Assert.True(game.Subsets[1].Cubes.Red == 0);
        Assert.True(game.Subsets[1].Cubes.Green == 5);
        Assert.True(game.Subsets[1].Cubes.Blue == 12);
        
        Assert.True(game.Subsets[2].Cubes.Red == 1);
        Assert.True(game.Subsets[2].Cubes.Green == 1);
        Assert.True(game.Subsets[2].Cubes.Blue == 14);
        
        Assert.True(game.Subsets[3].Cubes.Red == 5);
        Assert.True(game.Subsets[3].Cubes.Green == 6);
        Assert.True(game.Subsets[3].Cubes.Blue == 3);
        
        Assert.True(game.Subsets[4].Cubes.Red == 0);
        Assert.True(game.Subsets[4].Cubes.Green == 0);
        Assert.True(game.Subsets[4].Cubes.Blue == 9);
        
        Assert.True(game.Subsets[5].Cubes.Red == 6);
        Assert.True(game.Subsets[5].Cubes.Green == 0);
        Assert.True(game.Subsets[5].Cubes.Blue == 0);
        
    }

    #endregion

    #region Game

    [Fact]
    public void GameIsValid_Demo1_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);
        const string input = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.True(parser.GameIsValid(game));
    }
    
    [Fact]
    public void GameIsValid_Demo2_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);
        const string input = "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.True(parser.GameIsValid(game));
    }
    
    [Fact]
    public void GameIsValid_Demo3_False()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);
        const string input = "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.False(parser.GameIsValid(game));
    }
    
    [Fact]
    public void GameIsValid_Demo4_False()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);
        const string input = "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.False(parser.GameIsValid(game));
    }
    
    [Fact]
    public void GameIsValid_Demo5_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);
        const string input = "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green";

        // Act
        var game = CubeParser.ParseLine(input);

        // Assert
        Assert.True(parser.GameIsValid(game));
    }
    
    [Fact]
    public void GamesIsValid_Demo_True()
    {
        // Arrange
        var parser = new CubeParser(12, 13, 14);

        var games = new[]
        {
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green",
        };

        // Act
        var sumValidGames = parser.GetSumOfValidGames(games);

        // Assert
        Assert.Equal(8, sumValidGames);
    }
    
    [Fact]
    public void GetSumOfValidGamesPuissance_Demo_True()
    {
        var games = new[]
        {
            "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
            "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
            "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
            "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
            "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green",
        };

        // Act
        var sumValidGames = CubeParser.GetSumOfValidGamesPuissance(games);

        // Assert
        Assert.Equal(2286, sumValidGames);
    }

    #endregion
}