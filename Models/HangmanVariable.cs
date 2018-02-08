using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class HangmanVariable
  {
    private string _name;

    public string GetName()
    {
      return _name;
    }
    public void SetName(string userName)
    {
      _name = userName;
    }
  }
}
