using CongestionTaxCalculator.Domain.Common;
using CongestionTaxCalculator.Domain.Entities;
using CongestionTaxCalculator.Infrastructure.Services;

namespace CongestionTaxCalculator.Tests;

public class CarTaxCalculatorTest
{
    private TaxCalculator _taxCalculator = new TaxCalculator();
    List<Rule> rules = new List<Rule>()
    {
        new Rule {Id = 1, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 6, 0, 0), EndTime = new DateTime(1, 1, 1, 6, 29, 0), TaxValue = 8 },
            new Rule {Id = 2, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 6, 30, 0), EndTime = new DateTime(1, 1, 1, 6, 59, 0), TaxValue = 13 },
            new Rule {Id = 3, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 7, 0, 0), EndTime = new DateTime(1, 1, 1, 7, 59, 0), TaxValue = 18 },
            new Rule {Id = 4, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 8, 0, 0), EndTime = new DateTime(1, 1, 1, 8, 29, 0), TaxValue = 13 },
            new Rule {Id = 5, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 8, 30, 0), EndTime = new DateTime(1, 1, 1, 14, 59, 0), TaxValue = 8 },
            new Rule {Id = 6, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 15, 0, 0), EndTime = new DateTime(1, 1, 1, 15, 29, 0), TaxValue = 13 },
            new Rule {Id = 7, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 15, 30, 0), EndTime = new DateTime(1, 1, 1, 16, 59, 0), TaxValue = 18 },
            new Rule {Id = 8, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 17, 0, 0), EndTime = new DateTime(1, 1, 1, 17, 59, 0), TaxValue = 13 },
            new Rule {Id = 9, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 18, 0, 0), EndTime = new DateTime(1, 1, 1, 18, 29, 0), TaxValue = 8 },
            new Rule {Id = 10, CityName = "Gothenburg", StartTime = new DateTime(1, 1, 1, 18, 30, 0), EndTime = new DateTime(1, 1, 1, 5, 59, 0), TaxValue = 0 }
    };
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
            CurrentRegisteredTime = new DateTime(2013, 3, 29, 17, 26, 0), // Good Friday
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

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
            CurrentRegisteredTime = new DateTime(2013, 3, 28,17,26,0), // The day before Good Friday
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

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
            CurrentRegisteredTime = new DateTime(2013, 7, 28,17, 26, 0), // Random Day On July
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

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
            CurrentRegisteredTime = new DateTime(2013, 1, 5, 17, 26, 0), // January 5, 2013 is a Saturday
            LastTaxDateTime = new DateTime(2013, 1, 10, 18, 0, 0),
        };

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(0, car.LastTax);
    }

    [Fact]
    public void Any_Car_Tax_With_More_Than_One_Hour_Difference_Between_Two_Tolling_Station_Should_Return_Normal_Tax()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 0,
            TotalTax = 0,
            VehicleType = Vehicle.OrdinaryCar,
            CurrentRegisteredTime = new DateTime(2013, 1, 8, 14, 25, 0),
            LastTaxDateTime = new DateTime(2013, 1, 8, 13, 5, 0),
        };

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(8, car.LastTax);
    }

    [Fact]
    public void Any_Car_Tax_With_Less_Than_One_Hour_Difference_Between_Two_Tolling_Station_Should_Return_Max_Tax()
    {
        // Arrange
        Car car = new Car
        {
            LastTax = 13,
            TotalTax = 13,
            VehicleType = Vehicle.OrdinaryCar,
            CurrentRegisteredTime = new DateTime(2013, 1, 8, 14, 25, 0),
            LastTaxDateTime = new DateTime(2013, 1, 8, 14, 5, 0),
        };

        //Act
        _taxCalculator.CalcCarTax(car, rules);
        //Assert
        Assert.Equal(13, car.LastTax);
    }
}
