using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace RepeatCounter.Models
{
  public class RepeatCounterGenerator
  {
      private string _inputString;
      private string _findString;

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
      return "";
    }
  }
}
