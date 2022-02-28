namespace RockPaperScissorGameDemo{


public class Class1
{
    public string RandomComputerNumber(){
        Random _random = new Random();
        int randomChoice = _random.Next(1,4);
        string computerChoice = randomChoice.ToString();
        return computerChoice;
    }
    public string GameChoice(string input)
    {
        switch(input){

        case "1":
        string choice = "rock";
        return choice;
        case "2":
        string choiceTwo = "paper";
        return choiceTwo;
        case "3":
        string choiceThree = "scissors";
        return choiceThree;
        default:
        Console.WriteLine("Not a Valid Response");
        break;

        }
        return null;

    }



public void Outcome(string playerChoice, string computerChoice)
{
if(playerChoice == "rock" && computerChoice == "paper")
{
    YouLose();
}
else if(playerChoice == "paper" && computerChoice == "scissors")
{
     YouLose();
}

else if(playerChoice == "scissors" && computerChoice == "rock")
{
   YouLose();
}
else if(playerChoice == "rock" && computerChoice == "scissors")
{
    YouWin();
}
else if(playerChoice == "paper" && computerChoice == "rock")
{
     YouWin();
}

else if(playerChoice == "scissors" && computerChoice == "paper")
{
    YouWin();
}
else
{
    Console.WriteLine("NOBODY WINS");
}

}


public void YouWin()
{
    Console.WriteLine("YouWin");
}

public void YouLose()
{
    Console.WriteLine("YouLose");
}

}
}