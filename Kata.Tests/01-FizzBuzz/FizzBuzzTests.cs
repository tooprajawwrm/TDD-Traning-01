
namespace Kata.FizzBuzz.Tests;
public class FizzBuzzTests
{
    [Fact]
    public void SayHelloWorld_ShouldReturnHelloWorld()
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz();
        // Assert
        actual.Should().Be("Hello World!");
    }
}

