using System;
class Program
{
  static async Task Main()
  {
    Console.WriteLine("Tek sayılar:");
    List<int> liste = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
    var tekSayilar = liste.Where(x => TekSayiList.tekMi(x)).ToList();
    foreach (var sayi in tekSayilar)
    {
      Console.WriteLine(sayi);
    }
    Console.WriteLine("----------------------");

    Console.WriteLine("String birleştirme:");
    Console.WriteLine(StringMethod.birlestir("Furkan", "Demirtaş"));
    Console.WriteLine("----------------------");

    Console.WriteLine("Asenkron metot:");
    await Asenkron.RunAsync();
    Console.WriteLine("----------------------");

    Console.WriteLine("Karakter uzunluk kontrol:");
    bool uzunMu = StringLength.uzunlukKontrol("Furkan");
    if (uzunMu)
    {
      Console.WriteLine("5 karakterden uzun");
    }
    else
    {
      Console.WriteLine("5 karakterden kısa");
    }
    Console.WriteLine("----------------------");


    Console.WriteLine("Ogrenci yaş filtreleme:");
    List<Ogrenci> ogrenciler = new List<Ogrenci>
    {
      new Ogrenci { Ad = "Furkan", Soyad = "Demirtaş", Yas = 25 },
      new Ogrenci { Ad = "Ali", Soyad = "Veli", Yas = 17 },
      new Ogrenci { Ad = "Ayşe", Soyad = "Fatma", Yas = 35 },
      new Ogrenci { Ad = "Mehmet", Soyad = "Ahmet", Yas = 16 }
    };
    var filtrelenmisOgrenciler = ogrenciler.Where(x => x.Yas > 18).ToList();
    foreach (var ogrenci in filtrelenmisOgrenciler)
    {
      Console.WriteLine(ogrenci.Ad + " " + ogrenci.Soyad + " " + ogrenci.Yas);
    }
    Console.WriteLine("----------------------");

    Console.WriteLine("Ref metot:");
    int num = 100;
    RefMethod.KaresiniAl(ref num);
    Console.WriteLine(num);
    Console.WriteLine("----------------------");

    Console.WriteLine("Params metot:");
    Console.WriteLine(SayiToplaParams.Topla(1, 2, 3, 4, 5));
    Console.WriteLine("----------------------");

    Console.WriteLine("Log metot:");
    Logger.Log("Log mesajı");
    Console.WriteLine("----------------------");

    Console.WriteLine("Selam ver metot:");
    SelamVer.Selamla("Furkan");
    Console.WriteLine("----------------------");

    Console.WriteLine("Çarpma metot:");
    Console.WriteLine(Carpma.Carp(5, 10));
    Console.WriteLine("----------------------");

    Console.WriteLine("Çarpma metot overloading:");
    Console.WriteLine(Overloading.Carp(3, 3));
    Console.WriteLine(Overloading.Carp(5.5, 4.2));
    Console.WriteLine("----------------------");

    Console.WriteLine("String ters çevirme:");
    Console.WriteLine(ReverseString.TersCevir("Furkan"));
  }
}