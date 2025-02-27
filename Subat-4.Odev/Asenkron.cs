public class Asenkron
{
  public static async Task RunAsync()
  {
    Console.WriteLine("İşlem başladı");
    await Task.Delay(3000);
    Console.WriteLine("İşlem bitti");
  }
}