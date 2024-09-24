namespace Library.Game;

public interface IAttack
{
    public string Name { get; }
    public int Damage { get; }
    public PokemonType Type { get; }
}
