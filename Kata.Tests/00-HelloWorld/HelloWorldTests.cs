
namespace Kata.HelloWorld.Tests;
public class HelloWorldTests
{
    [Fact]
    public void SayHelloWorld_ShouldReturnHelloWorld()
    {
        // Arrange
        var sut = new HelloWorld();
        // Act
        var actual = sut.SayHelloWorld();
        // Assert
        actual.Should().Be("Hello World!");
    }
}

