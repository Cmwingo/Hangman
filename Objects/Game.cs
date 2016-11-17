using System.Collections.Generic;
using Nancy;

namespace GameState.Objects
{
  public class Game
  {
    public int Guesses {get; set;}
    public string AlreadyGuessed {get; set;}
    public string Answer {get; set;}
    public string PuzzleString {get; set;}
    public static List<Game> gameList = new List<Game>{};

    public Game(string answer)
      {
        this.Answer = answer;
        this.Guesses = 6;
        this.AlreadyGuessed = "";
        this.PuzzleString = GeneratePuzzleString(answer);
      }

    public string GeneratePuzzleString(string answer)
    {
      var puzzleString = "";
      for (int i = 0; i < answer.Length; i++)
      {
        puzzleString += "_ ";
      }
      return puzzleString;
    }
  }

  public class WordList
  {
    List<string> wordList = new List<string>{
      "test",
      "epicodus",
    };
    //function Wordchoser();
  }
}
