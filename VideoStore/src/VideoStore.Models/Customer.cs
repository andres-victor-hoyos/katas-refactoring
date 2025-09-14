namespace VideoStore.Models;
using System.Net;

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
        var result = $"Rental Record for {Name}\n";
        foreach (var rental in this.rentals)
        {
            result += $"\t{rental.Movie.Title}\t{rental.getCharge()}\n";
        }
        result += $"Amount owed is {this.getTotalCharge()}\n";
        result += $"You earned {this.getTotalGetFrecuentPoints()} frequent renter points";
        return result;
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

    private double getTotalGetFrecuentPoints()
    {
        double result = 0;
        foreach (var rental in this.rentals)
        {
            result += rental.getFrecuentRenterPoint();
        }
        return result;
    }    
}
