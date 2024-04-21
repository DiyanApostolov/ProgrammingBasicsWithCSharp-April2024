﻿// Input
double priceForTrip = double.Parse(Console.ReadLine());
int countOfPuzzles = int.Parse(Console.ReadLine());
int countOfDolls = int.Parse(Console.ReadLine());
int countOfBears = int.Parse(Console.ReadLine());
int countOfMinions = int.Parse(Console.ReadLine());
int countOfTrucks = int.Parse(Console.ReadLine());

// Calculations
double priceForAllPuzzles = countOfPuzzles * 2.60;
double priceForAllDolls = countOfDolls * 3;
double priceForAllBears = countOfBears * 4.10;
double priceForAllMinions = countOfMinions * 8.20;
double priceForAllTrucks = countOfTrucks * 2;

double income = priceForAllPuzzles + priceForAllDolls + priceForAllBears + priceForAllMinions + priceForAllTrucks;

int countOfAllToys = countOfPuzzles + countOfDolls + countOfBears + countOfMinions + countOfTrucks;

if (countOfAllToys >= 50)
{
    //income = income - (income * 0.25);
    income *= 0.75;
}

double rent = income * 0.1;

double finalIncome = income - rent;

// Output
if (priceForTrip <= finalIncome)
{
    double moneyLeft = finalIncome - priceForTrip;
    Console.WriteLine($"Yes! {moneyLeft:F2} lv left.");
}
else
{
    double moneyNeeded = priceForTrip - finalIncome;
    Console.WriteLine($"Not enough money! {moneyNeeded:F2} lv needed.");
}