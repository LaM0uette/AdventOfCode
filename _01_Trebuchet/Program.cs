namespace _01_Trebuchet;

 public static class Program
 {
     public static void Main()
     {
         var input = new[]
         {
             "1abc2",
             "pqr3stu8vwx",
             "a1b2c3d4e5f",
             "treb7uchet"
         };
        
         var result = Finder.GetSumOfCalibrationValues(input);
         Console.WriteLine(result);
     }
 }
 