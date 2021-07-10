
public class MyMath
{
    public decimal Pow(decimal number, decimal raiseToPower)
    {
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
