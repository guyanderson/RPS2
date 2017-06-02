using Nancy;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace RockPaperScissors.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["game.cshtml"];

      Post["/outcome"] = _ =>
      {
        Game newGame = new Game(Request.Form["player1"], Request.Form["player2"]);
        if(newGame.IsValid()){
          return View["/outcome.cshtml", newGame];
        } else {
          ViewBag.Error = "Please Spell rock, paper, or scissors correctly!";
          return View["/game.cshtml"];
        }
      };
    }
  }
}
