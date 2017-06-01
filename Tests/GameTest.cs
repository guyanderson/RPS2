

using Xunit;
namespace RockPaperScissors.Objects
{
  public class GameTest
  {
    [Fact]
// Name test:  METHOD, BEHAVIOR, OUTCOME
    public void CompareInputs_BothSame_ReturnsTie()
    {
      // ARRANGE:
      // set up fake test data
      string inputP1 = "rock";
      string inputP2 = "rock";
      // Instantiation  does not get fed data??
      Game newGame = new Game(inputP1, inputP2);
      // ACT: set _output
      newGame.CompareInputs();
      // ASSERT
      Assert.Equal("tie", newGame.GetOutput());
    }

    [Fact]
    public void CompareInputs_P1RockP2Sciss_ReturnsP1Win()
    {
      string inputP1 = "rock";
      string inputP2 = "scissors";
      Game newGame = new Game(inputP1, inputP2);
      newGame.CompareInputs();
      Assert.Equal("P1 Wins", newGame.GetOutput());
    }

    [Fact]
    public void CompareInputs_P1ScissP2Paper_ReturnsP1Win()
    {
      string inputP1 = "scissors";
      string inputP2 = "paper";
      Game newGame = new Game(inputP1, inputP2);
      newGame.CompareInputs();
      Assert.Equal("P1 Wins", newGame.GetOutput());
    }


    [Fact]
    public void CompareInputs_P1PaperP2Rock_ReturnsP1Win()
    {
      string inputP1 = "paper";
      string inputP2 = "rock";
      Game newGame = new Game(inputP1, inputP2);
      newGame.CompareInputs();
      Assert.Equal("P1 Wins", newGame.GetOutput());
    }
  }
}
