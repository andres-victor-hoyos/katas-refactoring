namespace VideoStore.Models;

public class NewReleasePrice : Price
{
    public override int GetPriceCode()
    {
        return 1;
    }

    public override int getFrequentRenterPoints(int days)
    {
        if (days > 1)
        {
            return 2;
        }
        return base.getFrequentRenterPoints(days);
    }

    public override double getCharge(int days)
    {
        return days * 3;
    }
}