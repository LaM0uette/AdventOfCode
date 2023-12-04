namespace Day01_Trebuchet;

 public static class Program
 {
     public static void Main()
     {
         const string file = "data.txt";
         var lines = File.ReadAllLines(file);
        
         var result = Finder.GetSumOfCalibrationValuesBis(lines);
         Console.WriteLine(result);
     }
 }
 