public class ReverseString
{
  public static string TersCevir(string s)
  {
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
  }
}