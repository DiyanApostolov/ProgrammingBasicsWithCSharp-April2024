// Input
double worldRecord = double.Parse(Console.ReadLine());
double distance = double.Parse(Console.ReadLine());
double timeToSwimOneMeter = double.Parse(Console.ReadLine());

// Calculations
double timeToSwim = distance * timeToSwimOneMeter;
double waterResist = Math.Floor(distance / 15) * 12.5;
double ivanchoTime = timeToSwim + waterResist;

// Output
if (ivanchoTime < worldRecord)
{
    Console.WriteLine($"Yes, he succeeded! The new world record is {ivanchoTime:F2} seconds.");
}
else
{
    double neededTime = ivanchoTime - worldRecord;
    Console.WriteLine($"No, he failed! He was {neededTime:F2} seconds slower.");
}