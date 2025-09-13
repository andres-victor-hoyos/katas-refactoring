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
        int frequentRenterPoints = 0;
        var statement = $"Rental Record for {Name}\n";
        foreach (var rental in this.rentals)
        {
            frequentRenterPoints += rental.getFrecuentRenterPoint();
            statement += $"\t{rental.Movie.Title}\t{rental.getCharge()}\n";
        }
        statement += $"Amount owed is {this.getTotalCharge()}\n";
        statement += $"You earned {frequentRenterPoints} frequent renter points";
        return statement;
    }

    private double getTotalCharge()
    {
        double result = 0;
        foreach (var rental in this.rentals)
        {
            result += rental.getCharge();
        }
        return result;
    }    
}
