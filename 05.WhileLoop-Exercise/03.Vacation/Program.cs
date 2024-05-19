
double moneyForTrip = double.Parse(Console.ReadLine());
double savedMoney = double.Parse(Console.ReadLine());

int daysCounter = 0;
int spendCounter = 0;

while (savedMoney < moneyForTrip)
{
	string whatJessyDo = Console.ReadLine(); // spend/save
	double amountOfMoney = double.Parse(Console.ReadLine());

	daysCounter++;

	if (whatJessyDo == "spend")
	{
		spendCounter++;
		savedMoney -= amountOfMoney;

		if (savedMoney < 0)
			savedMoney = 0;

		if (spendCounter == 5)
		{
            Console.WriteLine("You can't save the money.");
            Console.WriteLine($"{daysCounter}");
			break;
        }
	}
	else if (whatJessyDo == "save")
	{
		savedMoney += amountOfMoney;
		spendCounter = 0;
	}
}

if (savedMoney >= moneyForTrip)
{
    Console.WriteLine($"You saved the money for {daysCounter} days.");
}
