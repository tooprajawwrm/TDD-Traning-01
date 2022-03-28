using System;

namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        ValidateNumberInRange(number);
        if (IsBuzz(number) && IsFizz(number))
        {
            return "FizzBuzz";
        }
        if (IsBuzz(number))
        {
            return "Buzz";
        }
        if (IsFizz(number))
        {
            return "Fizz";
        }
        return number.ToString();
    }

    private void ValidateNumberInRange(int number)
    {
        if (number < 1 || number > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }
    }

    private bool IsFizz(int number)
    {
        return number % 3 == 0;
    }

    private bool IsBuzz(int number)
    {
        return number % 5 == 0;
    }
}