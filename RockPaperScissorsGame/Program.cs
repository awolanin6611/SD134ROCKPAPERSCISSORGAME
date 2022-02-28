using RockPaperScissorGameDemo;
Class1 _repo = new Class1();

Console.WriteLine("WELCOME TO THE WORLD OF ROCK & PAPER AND SCISSORS!!!!!\n");
Console.WriteLine("Press any key to continue.............................");
Console.ReadKey();
Console.Clear();
Console.Write("How would you like to appear on the leaderboard!!!!");
string userName = Console.ReadLine();
Console.WriteLine("I guess that is a cool name " + userName);
Console.WriteLine("If you are ready to begin hit any key...");
Console.ReadKey();


Console.WriteLine("Would you like to Choose Either ROCK, Paper or Scissors?\n");
Console.WriteLine("Choose 1 for Rock\n");
Console.WriteLine("Choose 2 for Paper\n");
Console.WriteLine("Choose 3 for Scissors");
string userInput = Console.ReadLine();
string userChoice = _repo.GameChoice(userInput);
string computerInput = _repo.RandomComputerNumber();
string computerChoice = _repo.GameChoice(computerInput);

_repo.Outcome(userChoice, computerChoice);
