using System;
using System.Text.RegularExpressions;

public static class Kata
{
  public static bool ValidPhoneNumber(string phoneNumber)
  {
        string pattern = @"^\(\d{3}\) \d{3}-\d{4}$";
        return Regex.IsMatch(phoneNumber, pattern);
  }
}
