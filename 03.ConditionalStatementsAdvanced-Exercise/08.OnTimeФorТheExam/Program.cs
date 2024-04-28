
int hourOfExam = int.Parse(Console.ReadLine());
int minutesOfExam = int.Parse(Console.ReadLine());
int hourOfArrival = int.Parse(Console.ReadLine());
int minutesOfArrival = int.Parse(Console.ReadLine());

int examTimeInMinutes = hourOfExam * 60 + minutesOfExam;
int arrivalTimeInMinutes = hourOfArrival * 60 + minutesOfArrival;

if (arrivalTimeInMinutes > examTimeInMinutes)
{
    Console.WriteLine("Late");

    int minutesLate = arrivalTimeInMinutes - examTimeInMinutes;

    if (minutesLate < 60)
    {
        Console.WriteLine($"{minutesLate} minutes after the start");
    }
    else
    {
        int hour = minutesLate / 60;
        int minutes = minutesLate % 60;

        Console.WriteLine($"{hour}:{minutes:D2} hours after the start");
    }
}
else if (examTimeInMinutes - arrivalTimeInMinutes <= 30)
{
    Console.WriteLine("On time");

    int minutesEarly = examTimeInMinutes - arrivalTimeInMinutes;

    if (minutesEarly != 0)
    {
        Console.WriteLine($"{minutesEarly} minutes before the start");
    }
}
else 
{
    Console.WriteLine("Early");

	int minutesEarly = examTimeInMinutes - arrivalTimeInMinutes;

    if (minutesEarly < 60)
    {
        Console.WriteLine($"{minutesEarly} minutes before the start");
    }
    else
    {
        int hour = minutesEarly / 60;
        int minutes = minutesEarly % 60;

        Console.WriteLine($"{hour}:{minutes:D2} hours before the start");
    }
}

