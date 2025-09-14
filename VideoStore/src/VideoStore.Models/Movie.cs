

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
    
    public int getFrecuentRenterPoint(int days)
    {
        int result = 1;
        if (this.PriceCode == 1 && days > 1)
            result++;
        return result;
    }
}
