namespace Game;

public interface IPokemon
{
    public int Health { get; set; }
    public int MaxHealth { get; }
    public int Attack { get; }
    public int Defense { get; }
    public int Speed { get; }


}
