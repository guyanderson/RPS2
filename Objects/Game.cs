using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{

  public class Game
  {
    private string _inputP1;
    private string _inputP2;
    //private string _output;

    public Game(string inputP1, string inputP2)
    {
      _inputP1 = inputP1;
      _inputP2 = inputP2;
      //_output = "";
      Console.WriteLine(_inputP1);
      Console.WriteLine(_inputP2);
    }

    public string GetOutput(){
      return CompareInputs();
    }

    public bool IsValid()
    {
      bool result = true;
      if ((_inputP1 != "rock") && (_inputP1 != "paper") && (_inputP1 != "scissors") || (_inputP2 != "rock") && (_inputP2 != "paper") && (_inputP2 != "scissors"))
      {
        result = false;
      }
      return result;
    }
    public string CompareInputs()
    {
      string output = "Player 2 wins!";
      // if ((_inputP1 != "rock") && (_inputP1 != "paper") && (_inputP1 != "scissors") || (_inputP2 != "rock") && (_inputP2 != "paper") && (_inputP2 != "scissors"))
      // {
      //   output = "Please Spell rock, paper, or scissors correctly!";
      // }
      if (_inputP1 == _inputP2) {
        output = "It's a Tie!";
      } else if (_inputP1 == "rock" && _inputP2 == "scissors") {
        output = "Player 1 wins!";
      } else if (_inputP1 == "scissors" && _inputP2 == "paper") {
        output = "Player 1 wins!";
      } else if (_inputP1 == "paper" && _inputP2 == "rock") {
        output = "Player 1 wins!";
      }
      return output;
    }
  }
}
