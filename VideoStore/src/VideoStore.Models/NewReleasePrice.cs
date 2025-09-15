namespace VideoStore.Models;

public class NewReleasePrice : Price
{
    private const double CHARGE = 3;
    private const int DAYS_RENTED_THREDSHOLD = 1;
    private const int FREQUENT_RENTER_POINTS = 2;
    public override int getFrequentRenterPoints(int days)
    {
        if (days > DAYS_RENTED_THREDSHOLD)
        {
            return FREQUENT_RENTER_POINTS;
        }
        return base.getFrequentRenterPoints(days);
    }

    public override double getCharge(int days)
    {
        return days * CHARGE;
    }
}