
int num = int.Parse(Console.ReadLine());

int p1 = 0;
int p2 = 0;
int p3 = 0;
int p4 = 0;
int p5 = 0;

for (int i = 0; i < num; i++)
{
	int currentNum = int.Parse(Console.ReadLine());

	if (currentNum < 200)
		p1++;
	else if (currentNum >=200 && currentNum <= 399)
		p2++; 
	else if (currentNum >= 400 && currentNum <=599)
		p3++;
	else if (currentNum >= 600 && currentNum <= 799)
		p4++;
	else if (currentNum >= 800)
		p5++;
}

double p1Percent = (double)p1 / num * 100.0;
double p2Percent = (double)p2 / num * 100.0;
double p3Percent = (double)p3 / num * 100.0;
double p4Percent = (double)p4 / num * 100.0;
double p5Percent = (double)p5 / num * 100.0;

Console.WriteLine($"{p1Percent:F2}%");
Console.WriteLine($"{p2Percent:F2}%");
Console.WriteLine($"{p3Percent:F2}%");
Console.WriteLine($"{p4Percent:F2}%");
Console.WriteLine($"{p5Percent:F2}%");
