namespace VideoStore.Models;

public class ChildrenPrice : Price
{
    private const double CHARGE = 1.5;
    private const double EXTRA_CHARGE = 1.5;
    private const double DAYS_RENTED_THREDSHOLD = 3;
    public override double getCharge(int days)
    {
        double result = CHARGE;
        if (days > DAYS_RENTED_THREDSHOLD)
            result += (days - 3) * EXTRA_CHARGE;
        return result;
    }
}
