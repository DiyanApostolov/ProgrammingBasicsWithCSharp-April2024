
int countOfTournaments = int.Parse(Console.ReadLine());
int startingPoints = int.Parse(Console.ReadLine());

int tournamentPoints = 0;
int winsCounter = 0;

for (int i = 0; i < countOfTournaments; i++)
{
	//възможен вход -> "W", "F" или "SF"
	string state = Console.ReadLine();

	if (state == "W")
	{
		tournamentPoints += 2000;
		winsCounter++;
	}
	else if (state == "F")
	{
		tournamentPoints += 1200;
	}
	else if (state == "SF")
	{
		tournamentPoints += 720;
	}
}

int finalPoints = startingPoints + tournamentPoints;
int averagePoints = tournamentPoints / countOfTournaments;
double winsPercent = (double)winsCounter / countOfTournaments * 100;

Console.WriteLine($"Final points: {finalPoints}");
Console.WriteLine($"Average points: {averagePoints}");
Console.WriteLine($"{winsPercent:F2}%");

