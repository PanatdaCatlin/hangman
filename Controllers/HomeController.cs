using Microsoft.AspNetCore.Mvc;
using Hangman.Models;
using System.Collections.Generic;

namespace Hangman.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/home")]
    public ActionResult Home()
    {
      return View();
    }
    [HttpGet("/hangman")]
    public ActionResult Hangman()
    {
      HangmanVariable myHangmanVariable = new HangmanVariable();
    myHangmanVariable.SetName(Request.Query["user-name"]);
      return View("Hangman", myHangmanVariable);
    }
    [HttpGet("/gameover")]
    public ActionResult GameOver()
    {
      return View("GameOver", myHangmanVariable);
    }

  }
}
