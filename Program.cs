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

//store Data on Home worlds and perks somewhere SQL? CSV? JSON?
//data for new regiments should be stored in a DB/CSV

//Add Print functionality
//Set Format for Print info should be clear and easy to read
//Add Search functionality
//Add Update functionality
//Add Delete functionality

//is a console app the best place for this or should it be a web app?
//if it is a web app, how do we handle the data storage?
//how do we handle the data storage in general?

