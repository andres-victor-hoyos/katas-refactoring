using System.Collections.Generic;
using VideoStore.Models;
using Xunit;

namespace VideoStore.Models.Tests
{
    public class CustomerTests
    {
        [Fact]
        public void Statement_NoRentals_ReturnsZeroAmountAndPoints()
        {
            var customer = new Customer("John");
            var expected = "Rental Record for John\nAmount owed is 0\nYou earned 0 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_OneRegularRental_TwoDays()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(
                new MovieBuilder().Title("The Godfather").Regular().Build(), 2));
            var expected = "Rental Record for John\n\tThe Godfather\t2\nAmount owed is 2\nYou earned 1 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_OneRegularRental_FourDays()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(
                new MovieBuilder().Title("The Godfather").Regular().Build(), 4));
            var expected = "Rental Record for John\n\tThe Godfather\t5\nAmount owed is 5\nYou earned 1 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_OneNewReleaseRental_OneDay()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(
                new MovieBuilder().Title("Avengers").NewRelease().Build(), 1));
            var expected = "Rental Record for John\n\tAvengers\t3\nAmount owed is 3\nYou earned 1 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_OneNewReleaseRental_TwoDays()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(
                new MovieBuilder().Title("Avengers").NewRelease().Build(), 2));
            var expected = "Rental Record for John\n\tAvengers\t6\nAmount owed is 6\nYou earned 2 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_OneChildrenRental_ThreeDays()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(
                new MovieBuilder().Title("Frozen").Children().Build(), 3));
            var expected = "Rental Record for John\n\tFrozen\t1.5\nAmount owed is 1.5\nYou earned 1 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_OneChildrenRental_FiveDays()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(new MovieBuilder().Title("Frozen").Children().Build(), 5));
            var expected = "Rental Record for John\n\tFrozen\t4.5\nAmount owed is 4.5\nYou earned 1 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }

        [Fact]
        public void Statement_MultipleRentals()
        {
            var customer = new Customer("John");
            customer.AddRental(new Rental(new MovieBuilder().Title("The Godfather").Regular().Build(), 3));
            customer.AddRental(new Rental(new MovieBuilder().Title("Avengers").NewRelease().Build(), 2));
            customer.AddRental(new Rental(new MovieBuilder().Title("Frozen").Children().Build(), 4));
            var expected = "Rental Record for John\n\tThe Godfather\t3.5\n\tAvengers\t6\n\tFrozen\t3\nAmount owed is 12.5\nYou earned 4 frequent renter points";
            Assert.Equal(expected, customer.Statement());
        }
    }
}
