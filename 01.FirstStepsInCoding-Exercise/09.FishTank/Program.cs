// Input
int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int high = int.Parse(Console.ReadLine());
double percent = double.Parse(Console.ReadLine());

// Calculations
double volumeOfTank = length * width * high / 1000.0;
double finalLiters = volumeOfTank * (1 - percent / 100);

//Output
Console.WriteLine(finalLiters);