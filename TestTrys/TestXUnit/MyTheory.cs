using TestXUnit.SandBox;

namespace TestXUnit;

public class MyTheory
{
    [Theory]
    [InlineData(2, 2, 4)]
    [InlineData(3, 3, 6)]
    [InlineData(2, 2, 5)]
    public void Theory(int x, int y, int sum)
    {
        Assert.Equal(sum, Calculator.Add(x, y));
    }
}