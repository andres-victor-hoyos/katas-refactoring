namespace VideoStore.Models;

public class RegularPrice : Price
{
    public override double getCharge(int days)
    {
        double result = 2;
        if (days > 2)
            result += (days - 2) * 1.5;
        return result;
    }
}
