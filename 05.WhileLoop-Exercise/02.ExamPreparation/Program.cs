
int maxPoorGrades = int.Parse(Console.ReadLine());
int problemsCounter = 0;
int allGrades = 0;
string lastProblem = "";
int countOfPoorGrades = 0;

while (true)
{
	string nameOfProblem = Console.ReadLine();

	if (nameOfProblem == "Enough")
	{
		double averageGrade = (double)allGrades / problemsCounter;

        Console.WriteLine($"Average score: {averageGrade:F2}");
        Console.WriteLine($"Number of problems: {problemsCounter}");
        Console.WriteLine($"Last problem: {lastProblem}");

        break;
	}

	int currentGrade = int.Parse(Console.ReadLine());
	problemsCounter++;
	allGrades += currentGrade;

	if (currentGrade <= 4)
	{
		countOfPoorGrades++;

		if (countOfPoorGrades == maxPoorGrades)
		{
            Console.WriteLine($"You need a break, {countOfPoorGrades} poor grades.");
            break;
		}
	}

	lastProblem = nameOfProblem;
}

