
int countOfPeopleInJury = int.Parse(Console.ReadLine());
int presentationCounter = 0;
double allGrades = 0;

string presentation = Console.ReadLine();

while (presentation != "Finish")
{
	presentationCounter++;
	double currentPresentationGrades = 0;

	for (int i = 0; i < countOfPeopleInJury; i++)
	{
		double currentGrade = double.Parse(Console.ReadLine());
		currentPresentationGrades += currentGrade;
	}

	double currentAverageGrade = currentPresentationGrades / countOfPeopleInJury;
	allGrades += currentAverageGrade;

    Console.WriteLine($"{presentation} - {currentAverageGrade:F2}.");

    presentation = Console.ReadLine();
}

double finalAssessment = allGrades / presentationCounter;

Console.WriteLine($"Student's final assessment is {finalAssessment:F2}.");
