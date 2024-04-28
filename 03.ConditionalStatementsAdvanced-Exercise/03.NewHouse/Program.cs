// "Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"

//цвете               Роза	Далия	Лале	Нарцис	Гладиола
//Цена на брой в лева	5	3.80	2.80	   3	 2.50

string typeOfFlower = Console.ReadLine();
int countOfFlower = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());

double finalPrice = 0;

switch (typeOfFlower)
{
	case "Roses":
		finalPrice = countOfFlower * 5;
		
		if (countOfFlower > 80)
		{
			finalPrice *= 0.9;
		}
		break;
	case "Dahlias":
		finalPrice = countOfFlower * 3.80;

		if (countOfFlower > 90)
		{
			finalPrice *= 0.85;
		}
		break;
	case "Tulips":
		finalPrice = countOfFlower * 2.80;

		if (countOfFlower > 80)
		{
			finalPrice *= 0.85;
		}
		break;
	case "Narcissus":
		finalPrice = countOfFlower * 3;

		if (countOfFlower < 120)
		{
			finalPrice *= 1.15;
		}
		break;
	case "Gladiolus":
		finalPrice = countOfFlower * 2.50;

		if (countOfFlower < 80)
		{
			finalPrice *= 1.2;
		}
		break;
}

double diff = Math.Abs(budget - finalPrice);

if (budget >= finalPrice)
{
    Console.WriteLine($"Hey, you have a great garden with {countOfFlower} {typeOfFlower} and {diff:F2} leva left.");
}
else
{
    Console.WriteLine($"Not enough money, you need {diff:F2} leva more.");
}