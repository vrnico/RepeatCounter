using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System;

namespace RepeatCounter.Models
{
  public class RepeatCounterGenerator
  {
      private string _inputString;
      private string _findString;
      private List<string> _compareWords = new List<string> {};

      public RepeatCounterGenerator(string inputString, string findString)
    {
      _inputString = inputString;
      _findString = findString;
    }

    public string GetInputString()
    {
      return _inputString;
    }

    public string GetFindString()
    {
      return _findString;
    }

    public List<string> GetCompareList()
   {
       return _compareWords;
   }


    public void BreakString()
    {
      string[] separators = {",", " ", "."};
      string[] words = _inputString.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index < words.Length; index ++)
      {
          _compareWords.Add(words[index]);
      }
    }
  }
}
