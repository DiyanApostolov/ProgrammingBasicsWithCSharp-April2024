// Input
int timeOfFirstAthlete = int.Parse(Console.ReadLine());
int timeOfSecondAthlete = int.Parse(Console.ReadLine());
int timeOfThirdAthlete = int.Parse(Console.ReadLine());

// Calculations
int sumSeconds = timeOfFirstAthlete + timeOfSecondAthlete + timeOfThirdAthlete;
int minutes = sumSeconds / 60;
int seconds = sumSeconds % 60;

//Output
if (seconds < 10)
{
    Console.WriteLine($"{minutes}:0{seconds}");
}
else
{
    Console.WriteLine($"{minutes}:{seconds}");
}