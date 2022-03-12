Console.Title = "LandoNet";

string skillIssue;
string command;

//Current Commands
string[] cmds = {"usa", "treetrain1", "math", "SecretCommands", "DropKickANewborn", "GCD (Greatest Common demoinator)", "Hacker", "credits"};


//Begin Operations
Console.WriteLine("How can I help you? You can say cmds for a list of commands!:");
command = Console.ReadLine();


//Begin Commands
//cmds Command

if (command == "cmds") {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("--------------------------------------");
    Console.ForegroundColor = ConsoleColor.Blue;
    for (int i = 0; i < cmds.Length; i++)
    {
        Console.WriteLine(cmds[i]);
    }
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("Please enter the command you want to issue from the list above!\n Do NOT enter cmds again!");
    command = Console.ReadLine();
}

//Calculator Command

if (command == "math") {
    Console.WriteLine("Type first number...");
		long x = Convert.ToInt64(Console.ReadLine());
		Console.WriteLine("Type...\n a for adding\n s for subtract\n m for multiply\n d for divide");
		string z = Console.ReadLine();
		Console.WriteLine("Type second number...");
		long y = Convert.ToInt64(Console.ReadLine());
		if (z == "a")
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Answer: {0}",x+y);
		}
		if (z == "s")
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Answer: {0}",x-y);
		}
		if (z == "m")
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Answer: {0}",x*y);
		}
		if (z == "d")
		{
            Console.ForegroundColor = ConsoleColor.Cyan;
			Console.WriteLine("Answer: {0}",x/y);
		}		   
}

//Greatest Common Denominator Command

if (command == "GCD") {
	  Console.Write(" First Number For GCD: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write(" Second Number For GCD: ");
            int n2 = Convert.ToInt32(Console.ReadLine());
             Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("--------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            while (n1 != n2)
            {
                if (n1 > n2)
                    n1 -= n2;
                else
                    n2 -= n1;
            }
            Console.WriteLine(" Greatest common denominator is " + n1);
}

//USA Command

else if (command == "usa") {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("WE");
    System.Threading.Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("LOVE");
    System.Threading.Thread.Sleep(1000);
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("GUNS");
}

//Treetrain1 Command

else if (command == "treetrain1") {
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

//LandoOnly

else if (command == "SecretCommands") {
    string password;
    string askedCommand;

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Please enter the password:");
    Console.ForegroundColor = ConsoleColor.White;

    password = Console.ReadLine();

    if (password == "TheTrueLando") {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Access Granted");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------");

        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("What would you like to do?");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("sayHello\n close");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------");
        Console.ForegroundColor = ConsoleColor.White;

        askedCommand = Console.ReadLine();

        if (askedCommand == "sayHello") {
            Console.WriteLine("Hello there!\n");
        }

        if (askedCommand == "close") {

        }
    }
    else if (password != "TheTrueLando") {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Access Denied!");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("---------------------");
    }
}


//DropKickANewborn Command

else if (command == "DropKickANewborn") {
    Console.WriteLine("Find a baby.");
    Console.WriteLine("Record video footage of it.");
    Console.WriteLine("Edit the footage (VERY POORLY) to make it say “I completely consent and understand the use of you showing an aggressive action towards me backed up with physical force, such as drop kicking me in the face. I agree with and understand the inevitable consequences for me, and my growth after this action has taken place. You are welcome to show aggression towards me.”");
    Console.WriteLine("Grab the baby, and sit it down.");
    Console.WriteLine("Cover yourself in honey.");
    Console.WriteLine("Go punch a honeycomb filled with bees.");
    Console.WriteLine("Let the bees cover you.");
    Console.WriteLine("Kick the baby, letting the bees come in contact with them.");
    Console.WriteLine("Let your actions have consequences. The baby consented to letting you drop kick them, but not get them heavily stung by a large amount of bees.");
    Console.WriteLine("Punch the police too. Remember, you're still covered in bees.");
    Console.WriteLine("Steal the officer's badge and clothing.");
    Console.WriteLine("Slap your mother. They will unground you from watching “Trolls: World Tour” and “The Smurfs 2”.");
    Console.WriteLine("Be racist. You're a cop now.");
    Console.WriteLine("Kick an elderly person down 23 flights of stairs. 1, they'll be covered in bees, 2, they'll break their collarbone, AND ONLY their collarbone. All old people break their collarbone.");
    Console.WriteLine("Find and assassinate a starving African kid. You're a cop.");
    Console.WriteLine(" Eat a very messy fruitcake made by your grandmother. You'll end up with AT LEAST 2 stains on your uniform.");
    Console.WriteLine("Kill Dream. You'll be loved for generations to come.");
    Console.WriteLine("Kill all of his fans, too. ALL 27 MILLION");
    Console.WriteLine("Tell a certain someone that saying “He Wuh” is not funny at all, and will never be funny. ");
    Console.WriteLine("Scream the number “Four” out loud in a very reverberated, and full mall. ");

    Console.WriteLine("Thats the first 20 steps on how to DropKickANewborn!");
}

//Credits Command

else if (command == "credits") {
    Console.WriteLine("https://www.kickababyscam.com");
    Console.WriteLine("Thanks to them for the 20 steps!");
}


//Hacker Command

else if (command == "Hacker") {
    Console.ForegroundColor = ConsoleColor.Green;
    for (;;) {
        int[] x = new int[10];
Random r = new Random();

while (x.Any(item => item == 1) == false)
{
    for (int i = 0; i < x.Length; i++)
    {
         x[i] = r.Next(0, 2);
    }
}

for (int i = 0; i < x.Length; i++)
{
   Console.WriteLine(x[i]);
}
    }
}

//Throw Error Command

else {
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("An error has occurred! It was most likely for one of the following reasons:");
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("You entered an unknown command (all commands are case sensitive)");
    Console.WriteLine("We had an error on our end. This cannot be fixed without manually adjusting the code.");
    Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------------------------------------------------------------------");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("You can contact the developer on discord:\n TheTrueLando#1890");
    
}

//Ending terminal

Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("----------------------------------------------------------------------------------");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine(".........................................All Operations Have Been Completed.........................................");
Console.WriteLine(".........................................You may now close this terminal.........................................");
Console.WriteLine("");
Console.ReadKey();
