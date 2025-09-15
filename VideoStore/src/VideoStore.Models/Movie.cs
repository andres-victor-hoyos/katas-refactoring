namespace VideoStore.Models;
// ...existing code...


public class Movie
{
    public string Title { get; }
    private Price Price { get; set; } = new RegularPrice();

    public Movie(string title, Price price)
    {
        this.Title = title;
        this.Price = price;
    }

    public double getCharge(int days)
    {
        return this.Price.getCharge(days);
    }

    public int getFrecuentRenterPoint(int days)
    {
        return this.Price.getFrequentRenterPoints(days);
    }
}
