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
    }
  }
}