namespace VideoStore.Models;

public class Customer
{
    public string Name { get; set; }
    public List<Rental> Rentals { get; set; }

    public Customer(string name)
    {
        this.Name = name;
        this.Rentals = new List<Rental>();
    }

    public Customer(string name, List<Rental> rentals)
    {
        this.Name = name;
        this.Rentals = rentals ?? new List<Rental>();
    }

    public string Statement()
    {
        double totalAmount = 0;
        int frequentRenterPoints = 0;
        var result = $"Rental Record for {Name}\n";
        foreach (var rental in Rentals)
        {
            double thisAmount = 0;
            switch (rental.Movie.PriceCode)
            {
                case 0: // Regular
                    thisAmount += 2;
                    if (rental.DaysRented > 2)
                        thisAmount += (rental.DaysRented - 2) * 1.5;
                    break;
                case 1: // New Release
                    thisAmount += rental.DaysRented * 3;
                    break;
                case 2: // Children
                    thisAmount += 1.5;
                    if (rental.DaysRented > 3)
                        thisAmount += (rental.DaysRented - 3) * 1.5;
                    break;
            }
            frequentRenterPoints++;
            if (rental.Movie.PriceCode == 1 && rental.DaysRented > 1)
                frequentRenterPoints++;
            result += $"\t{rental.Movie.Title}\t{thisAmount}\n";
            totalAmount += thisAmount;
        }
        result += $"Amount owed is {totalAmount}\n";
        result += $"You earned {frequentRenterPoints} frequent renter points";
        return result;
    }
}
