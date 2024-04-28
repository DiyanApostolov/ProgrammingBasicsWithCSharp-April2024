// „summer” или “winter”
// “Bulgaria", "Balkans” и ”Europe”
// „Camp” и „Hotel”

double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();

string destination = "";
string typeOfAccommodation = "";
double moneyForTrip = 0;

if (budget <= 100)
{
	destination = "Bulgaria";

	switch (season)
	{
		case "summer":
			moneyForTrip = 0.3 * budget;
			typeOfAccommodation = "Camp";
			break;
		case "winter":
			moneyForTrip = 0.7 * budget;
			typeOfAccommodation = "Hotel";
			break;
	}
}
else if (budget <= 1000)
{
	destination = "Balkans";

	switch (season)
	{
		case "summer":
			moneyForTrip = 0.4 * budget;
			typeOfAccommodation = "Camp";
			break;
		case "winter":
			moneyForTrip = 0.8 * budget;
			typeOfAccommodation = "Hotel";
			break;
	}
}
else if (budget > 1000)
{
	destination = "Europe";
	moneyForTrip = 0.9 * budget;
	typeOfAccommodation = "Hotel";
}


Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{typeOfAccommodation} - {moneyForTrip:F2}");