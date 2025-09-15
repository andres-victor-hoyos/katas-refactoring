namespace VideoStore.Models;
// ...existing code...


public class Movie
{
    public const int REGULAR = 0;
    public const int NEW_RELEASE = 1;
    public const int CHILDRENS = 2;
    public string Title { get; }
    private Price Price { get; set; } = new RegularPrice();

    public Movie(string title, int priceCode)
    {
        this.Title = title;
        this.SetPriceCode(priceCode);
    }

    public double getCharge(int days)
    {
        return this.Price.getCharge(days);
    }

    public int getFrecuentRenterPoint(int days)
    {
        return this.Price.getFrequentRenterPoints(days);
    }


    private void SetPriceCode(int priceCode)
    {
        switch (priceCode)
        {
            case Movie.REGULAR : this.Price = new RegularPrice(); break;
            case Movie.NEW_RELEASE: this.Price = new NewReleasePrice(); break;
            case Movie.CHILDRENS: this.Price = new ChildrenPrice();break;
            default: break;
        }
    }
}
