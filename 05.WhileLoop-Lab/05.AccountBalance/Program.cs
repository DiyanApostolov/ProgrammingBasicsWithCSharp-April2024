double balance = 0;
string input = Console.ReadLine();

while (input != "NoMoreMoney")
{
    double money = double.Parse(input);

    if (money < 0)
    {
        Console.WriteLine("Invalid operation!");
        break;
    }

    balance += money;
    Console.WriteLine($"Increase: {money:f2}");

    input = Console.ReadLine();
}

Console.WriteLine($"Total: {balance:f2}");