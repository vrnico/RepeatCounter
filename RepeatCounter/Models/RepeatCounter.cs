using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System;

namespace RepeatCounter.Models
{
  public class RepeatCounterGenerator
  {
      private string _inputString;

      public RepeatCounterGenerator(string inputString)
    {
      _inputString = inputString;
    }

    public string GetInputString()
    {
      return _inputString;
    }
  }
}
