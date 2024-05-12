
string nameOfActor = Console.ReadLine();
double academyPoints = double.Parse(Console.ReadLine());
int numberOfAssessors = int.Parse(Console.ReadLine());

for (int i = 0; i < numberOfAssessors; i++)
{
	string name = Console.ReadLine();
	double score = double.Parse(Console.ReadLine());

	double currentPoints = name.Length * score / 2;

	academyPoints += currentPoints;

	if (academyPoints > 1250.5)
	{
        Console.WriteLine($"Congratulations, {nameOfActor} got a nominee for leading role with {academyPoints:F1}!");
		break;
    }
}

if (academyPoints <= 1250.5)
{
	double neededPoints = 1250.5 - academyPoints;

	Console.WriteLine($"Sorry, {nameOfActor} you need {neededPoints:F1} more!");
}
