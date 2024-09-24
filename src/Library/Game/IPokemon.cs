namespace Library.Game;

public interface IPokemon
{
    public int Health { get; set; }
    public int MaxHealth { get; }
    public int AttackPoints { get; }
    public int DefensePoints { get; }
    public int Speed { get; }

    public PokemonType[] Types { get; }

    public IAttack[] Attacks { get; }

    public void Attack(IPokemon enemy, int moveIdx)
    {
        var attack = this.Attacks[moveIdx];
        var advantage = attack.Type.getAdvantage(enemy.Types[0]);
        throw new NotImplementedException("Attack method for pokemon is not implemented");
    }
}
