using System;

namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        ValidateNumberInRange(number);
        if (IsFizzBuzz(number))
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

    public void ValidateNumberInRange(int number)
    {
        if (number < 1 || number > 100)
        {
            throw new ArgumentOutOfRangeException(nameof(number));
        }
    }

    public bool IsFizzBuzz(int number)
    {
        return IsBuzz(number) && IsFizz(number);
    }

    public bool IsFizz(int number)
    {
        return number % 3 == 0;
    }

    public bool IsBuzz(int number)
    {
        return number % 5 == 0;
    }
}