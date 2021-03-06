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
        this.PuzzleString = Underscorify(answer);
      }

    public string Underscorify (string String) {
      string newString = "";
      for (int i = 0; i < String.Length; i++) {
        newString += "_";
        newString += "  ";
      }
      return newString;
    }

    public string Spacify (string String) {
      string newString = "";
      for (int i = 0; i < String.Length; i++) {
        newString += String[i];
        newString += "  ";
      }
      return newString;
    }

    public void GeneratePuzzleString(Game currentGame)
    {
      string puzzle = currentGame.Answer;
      string newPuzzle = "";
      string guessed = currentGame.AlreadyGuessed;
      for (int i = 0; i < puzzle.Length; i++ ){
        if (!guessed.Contains(puzzle[i].ToString())) {
          newPuzzle += "_";
        } else if (guessed.Contains(puzzle[i].ToString())) {
          newPuzzle += puzzle[i];
        } else {
          newPuzzle = "invalid";
        }
      }
      currentGame.PuzzleString = Spacify(newPuzzle);
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
