namespace VideoStore.Models;

public class Customer
{

    public string Name { get; set; }
    private List<Rental> rentals;

    public Customer(string name)
    {
        this.Name = name;
        this.rentals = new List<Rental>();
    }

    public void AddRental(Rental rental)
    {
        this.rentals.Add(rental);
    }

    public string Statement()
    {
        double totalAmount = 0;
        int frequentRenterPoints = 0;
        var result = $"Rental Record for {Name}\n";
    foreach (var rental in rentals)
        {
            double thisAmount = 0;
            switch (rental.Movie.PriceCode)
            {
                case Movie.REGULAR:
                    thisAmount += 2;
                    if (rental.DaysRented > 2)
                        thisAmount += (rental.DaysRented - 2) * 1.5;
                    break;
                case Movie.NEW_RELEASE:
                    thisAmount += rental.DaysRented * 3;
                    break;
                case Movie.CHILDRENS:
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
