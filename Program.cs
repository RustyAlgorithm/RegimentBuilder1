Console.WriteLine("++ Welcome to the Astra Militarum Regiment Registration System ++");
Console.WriteLine("Please enter the name of the regiment you wish to register:");
string regimentName = Console.ReadLine();
if (regimentName == null || regimentName.Length == 0)
{
    Console.WriteLine("Invalid regiment name. Exiting.");
    return;
}
Console.WriteLine("Please select a Homeworld for the regiment:");

string homeworld = Console.ReadLine();
if (homeworld == null || homeworld.Length == 0)
{
    Console.WriteLine("Invalid homeworld. Exiting.");
    return;
}