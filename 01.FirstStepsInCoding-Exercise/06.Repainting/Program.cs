// Prices 
double priceForNylon = 1.50;
double priceForPaint = 14.50;
double priceForDistiller = 5;
double priceForBags = 0.40;

// Input
int nylon = int.Parse(Console.ReadLine());
int paint = int.Parse(Console.ReadLine());
int distiller = int.Parse(Console.ReadLine());
int hoursForWorkers = int.Parse(Console.ReadLine());

// Calculations
double finalPriceForPaint = paint * 1.1 * priceForPaint;
double finalPriceForNylon = (nylon + 2) * priceForNylon;
double finalPriceForDistiller = distiller * priceForDistiller;
double priceForAllProducts = finalPriceForPaint + finalPriceForNylon + finalPriceForDistiller + priceForBags;

double priceForOneHoursOfWork = priceForAllProducts * 0.30;

double finalPrice = priceForAllProducts + (hoursForWorkers * priceForOneHoursOfWork);

// Output
Console.WriteLine(finalPrice);

