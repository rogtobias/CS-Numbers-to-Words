using Xunit;

namespace NumbersToWords.Objects
{
  public class NumbersToWordsTests
  {
    [Fact]
    public void NumbersToChange_5()
    {
      NumbersToWords newNumbersToWords = new NumbersToWords("5");
      Assert.Equal("five", newNumbersToWords.ChangeToWords());
    }

    [Fact]
    public void NumberToChange_13()
    {
      NumbersToWords newNumbersToWords = new NumbersToWords("13");
      Assert.Equal("thirteen", newNumbersToWords.ChangeToWords());
    }
  }
}
