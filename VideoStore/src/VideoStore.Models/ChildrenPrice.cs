namespace VideoStore.Models;

// Partial implementation: refactor for Switch Statement (sentencia alternativa múltiple) in progress
public class ChildrenPrice : Price
{
    public override int GetPriceCode()
    {
        return 2;
    }

    public override double getCharge(int days)
    {
        double result = 1.5;
        if (days > 3)
            result += (days - 3) * 1.5;
        return result;            
    }
}
