using System;
using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  // Car Factory
  public class Game
  {
    //Need a constructor for Cars - 2 in, 1 out
    private string _inputP1;
    private string _inputP2;
    private string _output;

    public Game(string inputP1, string inputP2)
    {
      _inputP1 = inputP1;
      _inputP2 = inputP2;
      _output = "";
    }

    public string GetOutput(){
      return _output;
    }

    public void CompareInputs(string _inputP1, string _inputP2)
    {
      if (_inputP1 == _inputP2)
      {
        _output = "tie";
      }
      else if (_inputP1 == "rock" && _inputP2 == "scissors")
      {
        _output = "P1 Wins";
      }

      else if (_inputP1 == "scissors" && _inputP2 == "paper")
      {
        _output = "P1 Wins";
      }

      else if (_inputP1 == "paper" && _inputP2 == "rock")
      {
        _output = "P1 Wins";
      }

      else
       {
        _output = "P2 Wins";
      }

    }
  }
}
