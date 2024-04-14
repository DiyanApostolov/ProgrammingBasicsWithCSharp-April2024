
// Input
int countOfPages = int.Parse(Console.ReadLine());
int readPagesPerHours = int.Parse(Console.ReadLine());
int countOfDays = int.Parse(Console.ReadLine());

// Calculations
int allHoursForRead = countOfPages / readPagesPerHours;
int hoursPerDay = allHoursForRead / countOfDays;

// Output
Console.WriteLine(hoursPerDay);