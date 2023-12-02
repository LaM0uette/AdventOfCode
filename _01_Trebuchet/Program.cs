namespace _01_Trebuchet;

 public static class Program
 {
     public static void Main()
     {
         const string file = "data.txt";
         var lines = File.ReadAllLines(file);
        
         var result = Finder.GetSumOfCalibrationValues(lines);
         Console.WriteLine(result);
     }
 }
 