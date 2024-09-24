namespace Program;

using Library.GameInteraction;

class Program
{
    static void Main(string[] args)
    {
        var game = TelegramGame.startGame();
        game.createPlayers();
        while (game.checkGameEnd() == 0)
        {
            game.playTurn();
            game.displayTurnResults();
        }
        game.endGame();
    }
}
