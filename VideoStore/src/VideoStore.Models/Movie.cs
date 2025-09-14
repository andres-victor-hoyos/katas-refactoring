namespace VideoStore.Models;
// ...existing code...


public class Movie
{
    public const int REGULAR = 0;
    public const int NEW_RELEASE = 1;
    public const int CHILDRENS = 2;
    public string Title { get; }
    public int PriceCode { get; }

    public Movie(string title, int priceCode)
    {
        this.Title = title;
        this.PriceCode = priceCode;
    }

    public double getCharge(int days)
    {
        double result = 0;
        switch (this.PriceCode)
        {
            case Movie.REGULAR:
                result += 2;
                if (days > 2)
                    result += (days - 2) * 1.5;
                break;
            case Movie.NEW_RELEASE:
                result += days * 3;
                break;
            case Movie.CHILDRENS:
                result += 1.5;
                if (days > 3)
                    result += (days - 3) * 1.5;
                break;
        }
        return result;
    }

    public int getFrecuentRenterPoint(int days)
    {
        int result = 1;
        if (this.PriceCode == 1 && days > 1)
            result++;
        return result;
    }
}
