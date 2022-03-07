Console.Title = "LandoNet";

string skillIssue;
string usa;
string instructions;

//Begin Operations
Console.WriteLine("How can I help you? You can say cmds for a list of commands!: ");
instructions = Console.ReadLine();

if (instructions == "cmds") {
    Console.WriteLine("treerain1\n usa");
    Console.WriteLine("How can I help you? You can say cmds for a list of commands!: ");
}
//Begin Commands
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

//treetrain1 command
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
}
}



//Unknown Command
else {
    Console.WriteLine("!!!\n Unknown Command, there is nothing else I can do.");
}







// Ending terminal
//System.Threading.Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine(".........................................Operations Complete.........................................");
Console.WriteLine("");
Console.ReadKey();