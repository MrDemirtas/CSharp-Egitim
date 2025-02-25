class Program
{
  static void Main()
  {
    // if else if else yapısı start
    Console.Write("Bir sayı giriniz: ");
    int sayi1 = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan sayı alınıyor
    if (sayi1 > 0) // Eğer sayı 0'dan büyükse
    {
      Console.WriteLine("Sayı pozitif");
    }
    else if (sayi1 < 0) // Eğer sayı 0'dan küçükse
    {
      Console.WriteLine("Sayı negatif");
    }
    else // Hiçbiri değilse sayı 0'dır
    {
      Console.WriteLine("Sayı sıfır");
    }
    // if else if else yapısı end

    Console.WriteLine("--------------------");

    // switch case yapısı start
    Console.Write("Bir sayı giriniz: ");
    int sayi2 = Convert.ToInt32(Console.ReadLine()); // Kullanıcıdan sayı alınıyor
    switch (sayi2) // Girilen sayıya göre işlem yapılıyor
    {
      case > 0: // Eğer sayı 0'dan büyükse
        Console.WriteLine("Sayı pozitif");
        break;
      case < 0: // Eğer sayı 0'dan küçükse
        Console.WriteLine("Sayı negatif");
        break;
      default: // Hiçbiri değilse sayı 0'dır
        Console.WriteLine("Sayı sıfır");
        break;
    }
    // switch case yapısı end

    Console.WriteLine("--------------------");

    // break ve continue kullanımı start
    for (int i = 0; i < 100; i++) // 0'dan 100'e kadar döngü
    {
      if (i == 50) // Eğer i 50'ye eşitse döngüden çık
      {
        break;
      }
      if (i % 2 != 0 || i % 10 == 0) // Eğer i çift sayı değilse veya 10'a bölünebiliyorsa döngüyü atla
      {
        continue;
      }
      Console.WriteLine(i); // i'yi ekrana yazdır
    }
    // break ve continue kullanımı end

    Console.WriteLine("--------------------");

    // foreach döngüsü start
    string[] isimler = { "Ali", "Ayşe", "Mehmet", "Zeynep", "Hasan" }; // İsimler dizisi
    foreach (var isim in isimler) // İsimler dizisindeki her bir isimi döngüye al
    {
      if (isim == "Zeynep") // Eğer isim Zeynep ise döngüyü atla
      {
        continue;
      }
      Console.WriteLine(isim); // İsimi ekrana yazdır
    }
    // foreach döngüsü end
  }
}