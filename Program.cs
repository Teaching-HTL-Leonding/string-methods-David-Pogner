Console.WriteLine("What do you want?\n1. Contains\n2. Index of\n3. LastIndexOf\n6. Remove");
int choice = int.Parse(Console.ReadLine()!);

switch (choice)
{
    case 1: Aufgabe1(); break;
    case 2: Aufgabe2(); break;
    case 3: Aufgabe3(); break;
    case 6: Aufgabe6(); break;
}


#region Aufgabe 1

void Aufgabe1()
{
    Console.Write("Please enter the text: ");
    string text = Console.ReadLine()!;

    Console.Write("Which char are you searching for: ");
    char searching = Console.ReadLine()![0];

    bool IsContain = Contains(text, searching);

    Console.WriteLine($"The char is: {IsContain}");
}

bool Contains(string text, char searching)
{
    if (text.Contains(searching))
    {
        return true;
    }
    else
    {
        return false;
    }
}

#endregion

#region Aufgabe 2

void Aufgabe2()
{
    Console.Write("Please enter your string: ");
    string searchingForString = Console.ReadLine()!;

    Console.Write("Enter the char you are searching for: ");
    char searchingForChar = Console.ReadLine()![0];

    int Output = IndexOf(searchingForString, searchingForChar);
    Console.WriteLine($"The index of the char is: {Output} ");
}

int IndexOf(string searchingForString, char searchingForChar)
{
    for (int i = 0; i < searchingForString.Length; i++)
    {
        if (searchingForString[i] == searchingForChar)
        {
            return i;
        }
    }
    return -1;
}

#endregion

#region Aufgabe 3

void Aufgabe3()
{
    Console.Write("Please enter the string: ");
    string searchingForString = Console.ReadLine()!;

    Console.Write("Enter the Char you are searching for: ");
    char searchingForChar = Console.ReadLine()![0];

    int TheLastIndex = LastIndexOf(searchingForString, searchingForChar);

    Console.WriteLine($"The Last index is {TheLastIndex}");
}

int LastIndexOf(string searchingForString, char searchingForChar)
{
    for (int i = searchingForString.Length - 1; i >= 0; i--)
    {
        if (searchingForString[i] == searchingForChar)
        {
            return i;
        }
    }
    return -1;
}

#endregion

#region Aufgabe 6

void Aufgabe6()
{
    Console.Write("Please enter the sting: ");
    string searchingForString = Console.ReadLine()!;

    Console.Write("Please enter the index: ");
    int index = int.Parse(Console.ReadLine()!);

    Console.Write("Please enter a defined number of characters: ");
    int NumberOfCaracters = int.Parse(Console.ReadLine()!);

    string Output = Remove(searchingForString, index, NumberOfCaracters);

    Console.WriteLine($"Your Output is: {Output}");
}

string Remove(string searchingForString, int index, int NumberOfCaracters)
{
    string OutputString = searchingForString.Remove(index, NumberOfCaracters);
    return OutputString;
}
#endregion