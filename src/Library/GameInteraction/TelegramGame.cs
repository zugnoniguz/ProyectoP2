namespace Library.GameInteraction;

public class TelegramGame : IGameInteraction
{
    public Game.Player[] Players { get; }

    private TelegramGame(Game.Player[] players)
    {
        if (players.Count() != 2)
        {
            throw new ArgumentOutOfRangeException($"Expected 2 players, got {players.Count()}");
        }
        this.Players = players;
    }

    public static IGameInteraction startGame()
    {
        throw new NotImplementedException("startGame is not implemented");
    }

    public Game.Player createPlayer()
    {
        throw new NotImplementedException("createPlayer is not implemented");
    }

    public void playTurn()
    {
        throw new NotImplementedException("createPlayer is not implemented");
    }

    public void displayTurnResults()
    {
        throw new NotImplementedException("displayTurnResults is not implemented");
    }

    public int checkGameEnd()
    {
        if (Players[0].isDead()) { return 1; }
        else if (Players[1].isDead()) { return 2; }
        else { return 0; }
    }

    public void endGame()
    {
        throw new NotImplementedException("createPlayer is not implemented");
    }
}
