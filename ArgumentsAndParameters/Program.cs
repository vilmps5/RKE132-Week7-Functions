
Console.WriteLine("Enter a text");
string userImput = Console.ReadLine();

PrintAnyWord(userImput);

static void PrintAnyWord(string anyString) //anyString - parameter
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    { 
        Console.WriteLine(anyString);
    }
}