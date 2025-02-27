public class Logger
{
  public static void Log(string log)
  {
    Console.WriteLine($"[{DateTime.Now}] {log}");
  }
}