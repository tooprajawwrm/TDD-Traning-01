
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

    [Theory]
    [InlineData(3)]
    [InlineData(6)]
    public void ShouldGetOnlyFizzCorrect(int number)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(number);
        // Assert
        actual.Should().Be("Fizz");
    }

    [Theory]
    [InlineData(5)]
    [InlineData(10)]
    public void ShouldGetOnlyBuzzCorrect(int number)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(number);
        // Assert
        actual.Should().Be("Buzz");
    }

    [Fact]
    public void ShouldGetFizzBuzzCorrect()
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(15);
        // Assert
        actual.Should().Be("FizzBuzz");
    }
}

