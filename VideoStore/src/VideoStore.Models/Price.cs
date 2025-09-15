
namespace VideoStore.Models;

public abstract class Price
{
    private const int FREQUENT_RENTER_POINTS = 1;
    public virtual int getFrequentRenterPoints(int days)
    {
        return FREQUENT_RENTER_POINTS;
    }
    public abstract double getCharge(int days);
}
