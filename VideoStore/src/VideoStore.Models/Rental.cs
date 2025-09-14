namespace VideoStore.Models;
// ...existing code...


public class Rental
{
    private int DaysRented { get; }
    public Movie Movie { get; }    

    public Rental(Movie movie, int daysRented)
    {
        this.Movie = movie;
        this.DaysRented = daysRented;
    }

    public double getCharge()
    {
        return this.Movie.getCharge(this.DaysRented);
    }

    public int getFrecuentRenterPoint()
    {
        return this.Movie.getFrecuentRenterPoint(DaysRented);
    }    
}
