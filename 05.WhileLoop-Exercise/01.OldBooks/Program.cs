
string favoriteBook = Console.ReadLine();

string currentBook = Console.ReadLine();

int bookCounter = 0;

while (currentBook != "No More Books")
{
	if (currentBook == favoriteBook)
	{
		break;
	}

	bookCounter++;

	currentBook = Console.ReadLine();
}

if (currentBook == "No More Books")
{
	Console.WriteLine("The book you search is not here!");
	Console.WriteLine($"You checked {bookCounter} books.");
}
else
{
	Console.WriteLine($"You checked {bookCounter} books and found it.");
}
