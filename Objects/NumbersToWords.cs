using System.Collections.Generic;
using System;

namespace NumbersToWords.Objects
{
  public class NumbersToWords
  {
    private string _userNumber;
    private char[] _userArray;
    private Dictionary<char, string> Numbers = new Dictionary<char, string> {};
    private Dictionary<char, string> Tens = new Dictionary<char, string> {};

    public NumbersToWords(string userNumber)
    {
      _userNumber = userNumber;
      _userArray = _userNumber.ToCharArray();
      AssignOnes();
      AssignTens();
    }

    public string GetNumber()
    {
      return _userNumber;
    }

    public void AssignOnes()
    {
      Numbers.Add('1', "one");
      Numbers.Add('2', "two");
      Numbers.Add('3', "three");
      Numbers.Add('4', "four");
      Numbers.Add('5', "five");
      Numbers.Add('6', "six");
      Numbers.Add('7', "seven");
      Numbers.Add('8', "eight");
      Numbers.Add('9', "nine");
    }

    public void AssignTens()
    {
      Tens.Add('0', "ten");
      Tens.Add('1', "eleven");
      Tens.Add('2', "twelve");
      Tens.Add('3', "thirteen");
      Tens.Add('4', "fourteen");
      Tens.Add('5', "fifteen");
      Tens.Add('6', "sixteen");
      Tens.Add('7', "seventeen");
      Tens.Add('8', "eighteen");
      Tens.Add('9', "nineteen");
    }

    public string ChangeToWords()
    {
      if(_userArray.Length > 1)
      {
        if(_userArray.Length == 2 && _userArray[0] != 1)
        {
          char test = _userArray[1];
          return Tens[test];
        }
        else
        {
          char test = _userArray[0];
          return Numbers[test];
        }
      }
      else
      {
        char test = _userArray[0];
        return Numbers[test];
      }
    }
  }
}
