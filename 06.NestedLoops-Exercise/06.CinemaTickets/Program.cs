string movieName = Console.ReadLine();

int studentCounter = 0;
int standardCounter = 0;
int kidCounter = 0;

while (movieName != "Finish")
{
	int freeSeats = int.Parse(Console.ReadLine());
	int ticketCounter = 0;

	for (int i = 0; i < freeSeats; i++)
	{
		//("student", "standard", "kid")
		string typeOfTicket = Console.ReadLine();

		if (typeOfTicket == "End")
			break;

		switch (typeOfTicket)
		{
			case "student":
				ticketCounter++;
				studentCounter++;
				break;
			case "standard":
				ticketCounter++;
				standardCounter++;
				break;
			case "kid":
				ticketCounter++;
				kidCounter++;
				break;
		}
	}

	double percentSoldTickets = (double)ticketCounter / freeSeats * 100;

	Console.WriteLine($"{movieName} - {percentSoldTickets:F2}% full.");

	movieName = Console.ReadLine();
}

int allTickets = studentCounter + standardCounter + kidCounter;
double percentSoldStudentTickets = (double)studentCounter / allTickets * 100;
double percentSoldStandardTickets = (double)standardCounter / allTickets * 100;
double percentSoldKidTickets = (double)kidCounter / allTickets * 100;

Console.WriteLine($"Total tickets: {allTickets}");
Console.WriteLine($"{percentSoldStudentTickets:F2}% student tickets.");
Console.WriteLine($"{percentSoldStandardTickets:F2}% standard tickets.");
Console.WriteLine($"{percentSoldKidTickets:F2}% kids tickets.");