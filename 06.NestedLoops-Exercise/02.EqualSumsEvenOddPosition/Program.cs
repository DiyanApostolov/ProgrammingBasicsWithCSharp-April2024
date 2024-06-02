int start = int.Parse(Console.ReadLine());
int end = int.Parse(Console.ReadLine());

for (int i = start; i <= end; i++)
{
	int oddSum = 0;
	int evenSum = 0;

	string currentNum = i.ToString();

	for (int j = 0; j < currentNum.Length; j++)
	{
		int currentDigit = int.Parse(currentNum[j].ToString());

		if (j % 2 == 0)
		{
			oddSum += currentDigit;
		}
		else
		{
			evenSum += currentDigit;
		}
	}

	if (evenSum == oddSum)
		Console.Write(currentNum + " ");
}