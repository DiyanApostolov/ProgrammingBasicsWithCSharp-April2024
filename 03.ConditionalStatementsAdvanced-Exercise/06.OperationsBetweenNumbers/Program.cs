
int numOne = int.Parse(Console.ReadLine());
int numTwo = int.Parse(Console.ReadLine());
char operation = char.Parse(Console.ReadLine());   //„+“, „-“, „*“, „/“, „%“

if (operation == '+' || operation == '-' || operation == '*')
{
	int result = 0;
	if (operation == '+')
	{
		result = numOne + numTwo;
	}
	else if (operation == '-')
	{
		result = numOne - numTwo;
	}
	else if (operation == '*')
	{
		result = numOne * numTwo;
	}

	string evenOrOdd = "even";
	if (result % 2 != 0)
		evenOrOdd = "odd";

    Console.WriteLine($"{numOne} {operation} {numTwo} = {result} - {evenOrOdd}");
}
else if (operation == '/')
{
	if (numTwo == 0)
	{
        Console.WriteLine($"Cannot divide {numOne} by zero");
    }
	else
	{
		double result = (double)numOne / numTwo;
		Console.WriteLine($"{numOne} / {numTwo} = {result:F2}");
	}
}
else if (operation == '%')
{
	if (numTwo == 0)
	{
		Console.WriteLine($"Cannot divide {numOne} by zero");
	}
	else
	{
		int result = numOne % numTwo;
		Console.WriteLine($"{numOne} % {numTwo} = {result}");
	}
}
