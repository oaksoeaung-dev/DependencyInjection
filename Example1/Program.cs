using Example1;

GameManager gameManager = new GameManager(new HumanPlayer(), new ComputerPlayer());

do
{
    RoundResult roundResult = gameManager.PlayRound();

    if (roundResult == RoundResult.Player1Win)
    {
        Console.WriteLine("Player 1 wins!");
    }
    else if (roundResult == RoundResult.Player2Win)
    {
        Console.WriteLine("Player 2 wins!");
    }
    else
    {
        Console.WriteLine("It's a draw!");
    }
    Console.Write("Play again ? (Y/N) :");
}while(Console.ReadLine().ToUpper() == "Y");