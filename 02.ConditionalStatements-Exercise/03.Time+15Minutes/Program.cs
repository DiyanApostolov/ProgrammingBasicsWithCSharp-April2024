
int inputHours = int.Parse(Console.ReadLine());
int inputMinutes = int.Parse(Console.ReadLine());

int minutesPlus15 = inputMinutes + 15;

int hour = inputHours + (minutesPlus15 / 60);
int minutes = minutesPlus15 % 60;

if (hour == 24)
{
    hour = 0;
}

Console.WriteLine($"{hour}:{minutes:D2}");
