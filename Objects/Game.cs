using System.Collections.Generic;
using Nancy;

namespace GameState
{
  public class Game
  {
    public int Guesses {get; set;}
    public string AlreadyGuessed {get; set;}
    public string Answer {get; set;}
    public string PuzzleString {get; set;}

    Game game = new Game (string answer)
    {
      game.Answer = answer;
      game.Guesses = 6;
      game.AlreadyGuessed = "";
      game.PuzzleString = GeneratePuzzleString(answer);
    }

    public string GeneratePuzzleString(string answer)
    {
      var puzzleString = "";
      for (int i = 0; i < answer.Length(); i++)
      {
        puzzleString += "_";
      }
      return puzzleString;
    }
  }

  public class WordList
  {
    List<String> wordList = new List<string>{
      "test",
      "epicodus",
    };
    //function Wordchoser();
  }
}
