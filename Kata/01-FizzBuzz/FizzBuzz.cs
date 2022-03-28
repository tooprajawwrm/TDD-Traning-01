namespace Kata.FizzBuzz;

public class FizzBuzz
{
    public string GetFizzBuzz(int number)
    {
        if (number % 3 == 0)
        {
            return "Fizz";
        }
        return number.ToString();
    }
}