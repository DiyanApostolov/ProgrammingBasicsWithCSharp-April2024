// Input
int countOfOpenTabs = int.Parse(Console.ReadLine());
double salary = double.Parse(Console.ReadLine());

// Calculations
for (int i = 0; i < countOfOpenTabs; i++)
{
	string openSite = Console.ReadLine();

	switch (openSite)
	{
		case "Facebook": salary -= 150; break;
		case "Instagram": salary -= 100; break;
		case "Reddit": salary -= 50; break;
	}

	if (salary <= 0)
	{
		Console.WriteLine("You have lost your salary.");
		break;
	}
}

// Output

if (salary > 0)
{
    Console.WriteLine(salary);
}
