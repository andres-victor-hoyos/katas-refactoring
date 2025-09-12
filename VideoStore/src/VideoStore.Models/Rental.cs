

public class Rental
{
    public Movie Movie { get; }
    public int DaysRented { get; }

    public Rental(Movie movie, int daysRented)
    {
        this.Movie = movie;
        this.DaysRented = daysRented;
    }

    public double getCharge()
    {
        double result = 0;
        switch (this.Movie.PriceCode)
        {
            case Movie.REGULAR:
                result += 2;
                if (this.DaysRented > 2)
                    result += (this.DaysRented - 2) * 1.5;
                break;
            case Movie.NEW_RELEASE:
                result += this.DaysRented * 3;
                break;
            case Movie.CHILDRENS:
                result += 1.5;
                if (this.DaysRented > 3)
                    result += (this.DaysRented - 3) * 1.5;
                break;
        }

        return result;
    }
}
