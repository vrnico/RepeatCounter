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
      private int _repeatCount = 0;
      private string _lowerInput;

      public RepeatCounterGenerator(string inputString, string findString, string lowerInput)
    {
      _inputString = inputString;
      _findString = findString;
      _lowerInput = lowerInput;
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

   public string LowerCase()
   {
     string lowerInput = _inputString.ToLower();

     return _lowerInput;
   }



    public void BreakString()
    {
      string[] separators = {",", " ", "."};
      string[] words = _lowerInput.ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
      for (int index = 0; index < words.Length; index ++)
      {
          _compareWords.Add(words[index]);
      }
    }


    public int RepeatCount()
    {
      int inputArray = ( _lowerInput.Length - _lowerInput.Replace(_findString,"").Length ) / _findString.Length;

          foreach (char findString in _lowerInput)
          {
              int valueHolder = inputArray;
              _repeatCount = valueHolder;
          }
          System.Console.WriteLine(inputArray);
      return _repeatCount;
    }



  }
}
