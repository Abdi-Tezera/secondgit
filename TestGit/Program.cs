Console.WriteLine("Välj ett användarnamn och tryck enter> ");
String userName = Console.ReadLine();bool checkNamn = true;
String[] storedNames = new string[] { "Abdi", "Nathan", "Erik" };
while (checkNamn)
{
    for (int i = 0; i < storedNames.Length; i++)
    {
        if (userName == storedNames[i])
        {
            Console.WriteLine("-Fel: Användarnamnet är upptaget. Försök igen.");
            Console.WriteLine("Ange användarnamn på nytt.");
            userName = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("Grattis du har loggat in");
            checkNamn = false;break;
        }
    }
}
