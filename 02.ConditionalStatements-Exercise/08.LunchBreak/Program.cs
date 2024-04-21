// Input
string nameOfTvSeries = Console.ReadLine();
int timeForTvSeries = int.Parse(Console.ReadLine());
int breakTime = int.Parse(Console.ReadLine());

// Calculations
double lunchTime = breakTime / 8.0;
double restTime = breakTime / 4.0;

double timeLeft = breakTime - lunchTime - restTime;
double difference = Math.Abs(timeLeft - timeForTvSeries);

// Output
if (timeLeft >= timeForTvSeries)
{
    Console.WriteLine($"You have enough time to watch {nameOfTvSeries} and left with {Math.Ceiling(difference)} minutes free time.");
}
else
{
    Console.WriteLine($"You don't have enough time to watch {nameOfTvSeries}, you need {Math.Ceiling(difference)} more minutes.");
}