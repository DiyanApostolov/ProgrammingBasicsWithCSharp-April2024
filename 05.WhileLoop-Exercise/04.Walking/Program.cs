
int walkingSteps = 0;

while (walkingSteps < 10000) 
{ 
	string input = Console.ReadLine();

	if (input == "Going home")
	{
		int stepsToHome = int.Parse(Console.ReadLine());
		walkingSteps += stepsToHome;
		break;
	}

	walkingSteps += int.Parse(input);
}

if (walkingSteps >= 10000)
{
	int moreSteps = walkingSteps - 10000;

    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{moreSteps} steps over the goal!");
}
else
{
	int neededSteps = 10000 - walkingSteps;
    Console.WriteLine($"{neededSteps} more steps to reach goal.");
}


