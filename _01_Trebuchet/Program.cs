namespace _01_Trebuchet;

 public static class Program
 {
     public static void Main()
     {
         var finder = new Finder();
         var input = "11";
         
         Console.WriteLine(finder.FindFirstAndLastDigits(input));
     }
 }
 