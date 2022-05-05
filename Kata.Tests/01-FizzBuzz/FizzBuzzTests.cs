
using System;

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

        var actual2 = sut.IsFizz(number);
        actual2.Should().Be(false);

        var actual3 = sut.IsBuzz(number);
        actual3.Should().Be(false);
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

        var actual2 = sut.IsFizz(number);
        actual2.Should().Be(true);
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

        var actual2 = sut.IsBuzz(number);
        actual2.Should().Be(true);
    }

    [Theory]
    [InlineData(15)]
    [InlineData(30)]
    public void ShouldGetFizzBuzzCorrect(int number)
    {
        // Arrange
        var sut = new FizzBuzz();
        // Act
        var actual = sut.GetFizzBuzz(number);
        // Assert
        actual.Should().Be("FizzBuzz");

        var actual2 = sut.IsFizzBuzz(number);
        actual2.Should().Be(true);
    }

    [Theory]
    [InlineData(0)]
    [InlineData(-10)]
    [InlineData(120)]
    [InlineData(1000)]
    public void ShouldThrowExceptionWhenArgumentOutOfRange(int number)
    {
        var sut = new FizzBuzz();
        //Action act = () => sut.GetFizzBuzz(number);
        Action act = () => sut.ValidateNumberInRange(number);
        act.Should().Throw<ArgumentOutOfRangeException>("number");
    }

    [Fact]
    public void ShouldPrintFizzBuzzCorrect()
    {
        var sut = new FizzBuzz();
        string arrange = "1 2 Fizz 4 Buzz Fizz 7 8 Fizz Buzz 11 Fizz 13 14 FizzBuzz 16 17 Fizz 19 Buzz Fizz 22 23 Fizz Buzz 26 Fizz 28 29 FizzBuzz 31 32 Fizz 34 Buzz Fizz 37 38 Fizz Buzz 41 Fizz 43 44 FizzBuzz 46 47 Fizz 49 Buzz Fizz 52 53 Fizz Buzz 56 Fizz 58 59 FizzBuzz 61 62 Fizz 64 Buzz Fizz 67 68 Fizz Buzz 71 Fizz 73 74 FizzBuzz 76 77 Fizz 79 Buzz Fizz 82 83 Fizz Buzz 86 Fizz 88 89 FizzBuzz 91 92 Fizz 94 Buzz Fizz 97 98 Fizz Buzz";
        string act = string.Empty;
        for (int number = 1; number <= 100; number++)
        {
            act += sut.GetFizzBuzz(number);
            if (number != 100)
            {
                act += " ";
            }
        }
        act.Should().Be(arrange);
    }
}

