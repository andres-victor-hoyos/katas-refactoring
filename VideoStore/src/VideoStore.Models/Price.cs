
namespace VideoStore.Models;

public abstract class Price
{
    public abstract int GetPriceCode();
    public virtual int getFrequentRenterPoints(int days)
    {
        return 1;
    }
    public abstract double getCharge(int days);
}
