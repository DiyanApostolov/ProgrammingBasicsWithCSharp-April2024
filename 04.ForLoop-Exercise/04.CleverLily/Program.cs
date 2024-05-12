// Input
int age = int.Parse(Console.ReadLine());
double priceOfWashingMachine = double.Parse(Console.ReadLine());
int priceForOneToy = int.Parse(Console.ReadLine());

// Calculations
double lilySavedMoney = 0;
int toyCounter = 0;
int moneyForEvenBirthDay = 10;

for (int birthDay = 1; birthDay <= age; birthDay++)
{
	if (birthDay % 2 == 0)
	{
		lilySavedMoney += moneyForEvenBirthDay - 1;
		moneyForEvenBirthDay += 10;
	}
	else
	{
		toyCounter++;
	}
}

double moneyFromToys = toyCounter * priceForOneToy;
lilySavedMoney += moneyFromToys;

// Output

if (lilySavedMoney >= priceOfWashingMachine)
{
	double moneyLeft = lilySavedMoney - priceOfWashingMachine;

    Console.WriteLine($"Yes! {moneyLeft:F2}");
}
else
{
	double neededMoney = priceOfWashingMachine - lilySavedMoney;

    Console.WriteLine($"No! {neededMoney:F2}");
}


