
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Theory]
    [InlineData(1, "1")]
    [InlineData(2, "2")]
    public void ShouldGetNumberCorrect(int number, string result)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(number);
        // Assert
        actual.Should().Be(result);
    }

    [Fact]
    public void ShouldGetFizzCorrect()
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(3);
        // Assert
        actual.Should().Be("Fizz");
    }
}

