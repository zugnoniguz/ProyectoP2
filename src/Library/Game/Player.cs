namespace Library.Game;

public class Player
{
    public string Name { get; }
    public int Id { get; }

    public IPokemon[] Party { get; }
    public int CurrentPokemon { get; set; }

    public Player(string name, int id, IPokemon[] pokemon)
    {
        this.Name = name;
        this.Id = id;
        if (pokemon.Count() != 6)
        {
            throw new ArgumentOutOfRangeException($"Expected 6 pokemon, got {pokemon.Count()}");
        }
        this.Party = pokemon;
    }

    public IPokemon getCurrentPokemon()
    {
        return this.Party[this.CurrentPokemon];
    }

    public void Attack(Player other, int moveIdx)
    {
        this.getCurrentPokemon().Attack(other.getCurrentPokemon(), moveIdx);
    }

    public bool isDead()
    {
        return this.Party.All((p) => p.Health == 0);
    }
}
