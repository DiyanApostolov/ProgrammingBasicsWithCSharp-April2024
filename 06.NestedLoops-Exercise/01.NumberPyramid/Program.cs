
int n = int.Parse(Console.ReadLine());

int counter = 0;
bool flag = false;

for (int row = 1; row <= n; row++)
{
	for ( int i = 1; i <= row; i++)
	{
		counter++;

		if (counter > n)
		{
			flag = true;
			break;
		}

		Console.Write(counter + " ");
    }

    if (flag)
	{
		break;
	}

    Console.WriteLine();
}
