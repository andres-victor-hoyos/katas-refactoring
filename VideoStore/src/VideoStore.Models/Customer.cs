using System.Net;

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
        foreach (var rental in this.rentals)
        {
            double thisAmount = 0;
            thisAmount = rental.getCharge();
            frequentRenterPoints += rental.getFrecuentRenterPoint();
            result += $"\t{rental.Movie.Title}\t{rental.getCharge()}\n";
            totalAmount += rental.getCharge();
        }
        result += $"Amount owed is {totalAmount}\n";
        result += $"You earned {frequentRenterPoints} frequent renter points";
        return result;
    }
    
}
