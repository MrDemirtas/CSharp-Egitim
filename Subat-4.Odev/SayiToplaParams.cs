class SayiToplaParams
{
  public static int Topla(params int[] sayilar)
  {
    int toplam = 0;
    foreach (int sayi in sayilar)
    {
      toplam += sayi;
    }
    return toplam;
  }
}