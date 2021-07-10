using System;

public class MyMath
{
    public decimal Pow(decimal number, decimal raiseToPower)
    {
        if (number > 10 || raiseToPower > 10 ||
            number < -10 || raiseToPower < -10)
            throw new ArgumentOutOfRangeException($"{nameof(number)} and " +
                $"{nameof(raiseToPower)} should between -10 and 10");
        decimal result;
        if (raiseToPower < 0)
        {
            raiseToPower *= -1;
            result = 1 / number;
            for (int i = 1; i < raiseToPower; i++)
            {
                result /= number;
            }
        }
        else
        {
            result = number;
            for (int i = 1; i < raiseToPower; i++)
            {
                result *= number;
            }
        }
        return result;
    }
}