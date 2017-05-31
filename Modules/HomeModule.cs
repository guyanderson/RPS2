using Nancy;
using System.Collections.Generic;
using RockPaperScissors.Objects;

namespace RockPaperScissors.Objects
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      // ROOT to game.cshtml
      Get["/"] = _ => View["game.cshtml"];

      Post["/game/outcome"] = _ =>
      {
        // newGame.GetOutput();

        Game newGame = new Game(Request.Form["player1"], Request.Form["player2"]);
        newGame.CompareInputs(Request.Form["player1"], Request.Form["player2"]);
        return View["/game/outcome.cshtml", newGame];
      };
    }
  }
}
