
int num = int.Parse(Console.ReadLine());

int sum = 0;
int maxNum = int.MinValue;

for (int i = 1; i <= num; i++)
{
	int currentNum = int.Parse(Console.ReadLine());
	sum += currentNum;

	if (currentNum > maxNum)
	{  
		maxNum = currentNum; 
	}
}

int sumWithoutMaxNum = sum - maxNum;

if (sumWithoutMaxNum == maxNum)
{
    Console.WriteLine("Yes");
    Console.WriteLine($"Sum = {sumWithoutMaxNum}");
}
else
{
	int diff = Math.Abs(sumWithoutMaxNum - maxNum);

    Console.WriteLine("No");
    Console.WriteLine($"Diff = {diff}");

}