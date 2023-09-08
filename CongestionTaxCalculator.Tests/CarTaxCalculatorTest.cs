using CongestionTaxCalculator.Domain.Common;
using CongestionTaxCalculator.Domain.Entities;
using CongestionTaxCalculator.Infrastructure.Services;

namespace CongestionTaxCalculator.Tests;

public class CarTaxCalculatorTest
{
    private TaxCalculator _taxCalculator = new TaxCalculator();
    [Fact]
    public void Emergency_Car_Tax_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.Emergency,
            CurrentRegisteredTime = new DateTime(2013, 1, 14, 21, 0, 0),
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Military_Car_Tax_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.Military,
            CurrentRegisteredTime = new DateTime(2013, 1, 14, 21, 0, 0),
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Foreign_Car_Tax_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.Foreign,
            CurrentRegisteredTime = new DateTime(2013, 1, 14, 21, 0, 0),
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Any_Car_Tax_On_Holiday_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.OrdinaryCar,
            CurrentRegisteredTime = new DateTime(2013, 3, 29), // Good Friday
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Any_Car_Tax_On_Day_Before_Holiday_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.OrdinaryCar,
            CurrentRegisteredTime = new DateTime(2013, 3, 28), // The day before Good Friday
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Any_Car_Tax_On_July_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.OrdinaryCar,
            CurrentRegisteredTime = new DateTime(2013, 7, 28), // Random Day On July
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Any_Car_Tax_On_Saturday_Should_Return_Zero()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.OrdinaryCar,
            CurrentRegisteredTime = new DateTime(2013, 1, 5), // January 5, 2013 is a Saturday
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        var rules = new List<Rule>();

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }
}
