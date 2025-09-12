

public class Rental
{
    public Movie Movie { get; }
    public int DaysRented { get; }

    public Rental(Movie movie, int daysRented)
    {
        this.Movie = movie;
        this.DaysRented = daysRented;
    }
}
