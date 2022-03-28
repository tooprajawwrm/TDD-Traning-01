using System;

namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (number < 1 || number > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }
        if (number % 3 == 0 && number % 5 == 0)
        {
            return "FizzBuzz";
        }
        if (number % 5 == 0)
        {
            return "Buzz";
        }
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}