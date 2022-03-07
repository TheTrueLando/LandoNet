Console.Title = "LandoNet";

string skillIssue;
string instructions;

//Current Commands
string[] cmds = {"usa", "treetrain1", "math"};


//Begin Operations
Console.WriteLine("How can I help you? You can say cmds for a list of commands!:");
instructions = Console.ReadLine();


//Begin Commands
//cmds Command

if (instructions == "cmds") {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--------------------------------------");
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < cmds.Length; i++)
    {
        Console.WriteLine(cmds[i]);
    }
}

//Calculator Command

if (instructions == "math") {
    Console.WriteLine("Type first number...");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Type...\n a for adding\n s for subtract\n m for multiply\n d for divide");
		string z = Console.ReadLine();
		Console.WriteLine("Type second number...");
		int y = Convert.ToInt32(Console.ReadLine());
		if (z == "a")
		{
			Console.WriteLine("Answer: {0}",x+y);
		}
		if (z == "s")
		{
			Console.WriteLine("Answer: {0}",x-y);
		}
		if (z == "m")
		{
			Console.WriteLine("Answer: {0}",x*y);
		}
		if (z == "d")
		{
			Console.WriteLine("Answer: {0}",x/y);
		}
		   
}

//USA Command

else if (instructions == "usa") {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("WE");
    System.Threading.Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("LOVE");
    System.Threading.Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("GUNS");
}

//treetrain1 Command

else if (instructions == "treetrain1") {
    Console.WriteLine("Does treetrain1 have a skill issue?: ");
skillIssue = Console.ReadLine();
if (skillIssue == "yes") {
    Console.WriteLine("Im so happy you got the right answer!");
}
else if (skillIssue == "no") {
    Console.WriteLine("Are you crazy? He does. Frick off.");
}
else {
    Console.WriteLine("Try saying yes or no. I dont know what you typed!");
    Console.ReadLine();
}
}





else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Unknown command, please try again.");
}

// Ending terminal
//System.Threading.Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(".........................................All Operations Have Been Completed.........................................");
Console.WriteLine(".........................................You may now close this terminal.........................................");
Console.WriteLine("");
Console.ReadKey();
