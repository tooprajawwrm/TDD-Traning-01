
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Fact]
    public void ShouldGetNumberCorrect()
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(1);
        // Assert
        actual.Should().Be("1");
    }
}

