# Congestion Tax Calculator
This repository contains a .NET 7 and C# implementation of a Congestion Tax Calculator (a simple and sample congestion tax calculator). The application calculates congestion tax fees for vehicles within the Gothenburg area. This solution uses clean architecture and CQRS for implementaion also XUnit for tests. some of packages or libraries that are used in this solution are:
- AutoMapper
* MediatR
+ FluentValidation

# Installation
To install and run the application, follow these steps:

Clone this repository to your local machine.
Open the solution in Visual Studio 2022.
Build the solution.
Run the application.

# Usage
The application provides a simple user interface that allows you to enter the date and time of your trip within the Gothenburg area. The application will then calculate the congestion tax fee based on the date and time of your trip.

# Development
If you want to expand this solution to other cities, its enough to add rules for other cities. also it is possible that remove CityName from Rule entity and create Cities table and create a relation between Cities table and Rules table.
If you create new table for city, you will need to implement CityRepository. The important point in this solution is that, it is maintainable and expandable. With this solution also you can set differrent rules for differrent vehicles in differrent cities.
