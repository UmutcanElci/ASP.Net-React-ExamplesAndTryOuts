using TestXUnit.SandBox;

namespace TestXUnit;

public class UnitTest1
{
    [Fact]
    public void PassingTest()
    {
        Assert.Equal(4,Calculator.Add(2, 2));
    }

    [Fact]
    public void FailingTest()
    {
        Assert.Equal(5, Calculator.Add(2, 2));
    }
}