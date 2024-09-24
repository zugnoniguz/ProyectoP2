namespace Library.GameInteraction;

public interface IGameInteraction
{
    public Game.Player[] Players { get; }

    public abstract static IGameInteraction startGame();
    public Game.Player createPlayer();
    public void createPlayers()
    {
        this.Players[0] = this.createPlayer();
        this.Players[1] = this.createPlayer();
    }
    public void playTurn();
    public void displayTurnResults();
    public int checkGameEnd()
    {
        if (Players[0].isDead()) { return 1; }
        else if (Players[1].isDead()) { return 2; }
        else { return 0; }
    }
    public void endGame();
}
