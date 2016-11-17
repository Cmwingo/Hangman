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
        Game game = new Game("test");
        Game.gameList.Add(game);
        return View["game.cshtml", game];
      };
      Post["/guess"] = _ => {
        Game currentGame = Game.gameList[0];
        currentGame.PuzzleString = "test";
        return View["game.cshtml", currentGame];
      };
    }
  }
}

// Post["/guess"] = _ => {
//   string guess = Request.Form["guess"];
//   string answer = Game.Answer();
//   Game.AlreadyGuessed += guess;
//   if(answer.Contains(guess))
//   {
//     System.Console.WriteLine("You guessed one");
//   }
//   else
//   {
//     System.Console.WriteLine("You didn't guess one");
//   }
//   return View["game.cshtml"];
// };
