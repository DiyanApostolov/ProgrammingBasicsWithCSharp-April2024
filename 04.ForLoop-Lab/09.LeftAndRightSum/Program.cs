
int num = int.Parse(Console.ReadLine());

int leftSum = 0;
int rightSum = 0;

// left sum
for (int i = 0; i < num; i++)
{
	int currentNum = int.Parse(Console.ReadLine());
	leftSum += currentNum;
}

// right sum
for (int i = 0;i < num; i++)
{
	int currentNum = int.Parse(Console.ReadLine());
	rightSum += currentNum;
}

if (leftSum == rightSum)
{
    Console.WriteLine($"Yes, sum = {leftSum}");
}
else
{
    int diff = Math.Abs(leftSum - rightSum);

    Console.WriteLine($"No, diff = {diff}");
}