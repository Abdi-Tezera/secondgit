Console.WriteLine("Välj ett användarnamn och tryck enter> ");
String userName = Console.ReadLine();bool checkNamn = true;
while (checkNamn)
{
    if (userName == "Abdi")
    {
        Console.WriteLine("-Fel: Användarnamnet är upptaget. Försök igen.");
        Console.WriteLine("Ange användarnamn på nytt.");
        userName = Console.ReadLine();
    }
    else
    {
    Console.WriteLine("Grattis du har loggat in");
        checkNamn = false;
    }
}
