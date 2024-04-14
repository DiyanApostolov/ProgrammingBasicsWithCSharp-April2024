
// Prices
double pricePen = 5.80;
double priceMarker = 7.20;
double pricePreparat = 1.20;

//Input
int countOfPens = int.Parse(Console.ReadLine());
int countOfMarkers = int.Parse(Console.ReadLine());
int litersPreparat = int.Parse(Console.ReadLine());
int percentDiscount = int.Parse(Console.ReadLine());

// Calculations
double priceForAllPens = countOfPens * pricePen;
double priceForAllMarkers = countOfMarkers * priceMarker;
double priceForAllPreparat = litersPreparat * pricePreparat;

double priceForProducts = priceForAllPens + priceForAllMarkers + priceForAllPreparat;
double discount = priceForProducts * percentDiscount / 100;
double finalPrice = priceForProducts - discount;

//Output
Console.WriteLine(finalPrice);
