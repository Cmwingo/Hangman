using Nancy;
using System.Collections.Generic;
using GameState.Objects;

namespace GameState
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["index.cshtml"];
      Post["/start"] = _ =>
      {
        Game game = new Game("epicodus");
        Game.gameList.Clear();
        Game.gameList.Add(game);
        return View["game.cshtml", game];
      };
      Post["/guess"] = _ => {
        Game currentGame = Game.gameList[0];
        string guess = Request.Form["guess"];
        currentGame.AlreadyGuessed += guess;
        currentGame.GeneratePuzzleString(currentGame);
        return View["game.cshtml", currentGame];
      };
    }
  }
}
