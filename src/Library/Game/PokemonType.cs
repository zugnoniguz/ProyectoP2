namespace Library.Game;

public enum PokemonType
{
    Normal,
    Fire,
    Water,
    Electric,
    Grass,
    Ice,
    Fighting,
    Poison,
    Ground,
    Flying,
    Psychic,
    Bug,
    Rock,
    Ghost,
    Dragon
}

// Define an extension method in a non-nested static class.
public static class Extensions
{
    public static double getAdvantage(this PokemonType ty, PokemonType other)
    {
        const double effectNone = 0.0;
        const double effectNotVery = 0.5;
        const double effectNormal = 1.0;
        const double effectSuper = 2.0;

        switch (ty)
        {
            case PokemonType.Normal:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNormal;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNotVery;
                    case PokemonType.Ghost:
                        return effectNone;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Fire:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNotVery;
                    case PokemonType.Water:
                        return effectNotVery;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectSuper;
                    case PokemonType.Ice:
                        return effectSuper;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectSuper;
                    case PokemonType.Rock:
                        return effectNotVery;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNotVery;
                }
                break;

            case PokemonType.Water:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectSuper;
                    case PokemonType.Water:
                        return effectNotVery;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNotVery;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectSuper;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectSuper;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNotVery;
                }
                break;

            case PokemonType.Electric:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectSuper;
                    case PokemonType.Electric:
                        return effectNotVery;
                    case PokemonType.Grass:
                        return effectNotVery;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNone;
                    case PokemonType.Flying:
                        return effectSuper;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNotVery;
                }
                break;

            case PokemonType.Grass:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNotVery;
                    case PokemonType.Water:
                        return effectSuper;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNotVery;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNotVery;
                    case PokemonType.Ground:
                        return effectSuper;
                    case PokemonType.Flying:
                        return effectNotVery;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNotVery;
                    case PokemonType.Rock:
                        return effectSuper;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNotVery;
                }
                break;

            case PokemonType.Ice:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNotVery;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectSuper;
                    case PokemonType.Ice:
                        return effectNotVery;
                    case PokemonType.Fighting:
                        return effectNotVery;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectSuper;
                    case PokemonType.Flying:
                        return effectSuper;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectSuper;
                }
                break;

            case PokemonType.Fighting:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectSuper;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNormal;
                    case PokemonType.Ice:
                        return effectSuper;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNotVery;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNotVery;
                    case PokemonType.Psychic:
                        return effectNotVery;
                    case PokemonType.Bug:
                        return effectNotVery;
                    case PokemonType.Rock:
                        return effectSuper;
                    case PokemonType.Ghost:
                        return effectNone;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Poison:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectSuper;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNotVery;
                    case PokemonType.Ground:
                        return effectNotVery;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectSuper;
                    case PokemonType.Rock:
                        return effectNotVery;
                    case PokemonType.Ghost:
                        return effectNotVery;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Ground:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectSuper;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectSuper;
                    case PokemonType.Grass:
                        return effectNotVery;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectSuper;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNone;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNotVery;
                    case PokemonType.Rock:
                        return effectSuper;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Flying:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNotVery;
                    case PokemonType.Grass:
                        return effectSuper;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectSuper;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectSuper;
                    case PokemonType.Rock:
                        return effectNotVery;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Psychic:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNormal;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectSuper;
                    case PokemonType.Poison:
                        return effectSuper;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNotVery;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Bug:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNotVery;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectSuper;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNotVery;
                    case PokemonType.Poison:
                        return effectSuper;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNotVery;
                    case PokemonType.Psychic:
                        return effectSuper;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectNotVery;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Rock:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectSuper;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNormal;
                    case PokemonType.Ice:
                        return effectSuper;
                    case PokemonType.Fighting:
                        return effectNotVery;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNotVery;
                    case PokemonType.Flying:
                        return effectSuper;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectSuper;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Ghost:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNone;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNormal;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNone;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectSuper;
                    case PokemonType.Dragon:
                        return effectNormal;
                }
                break;

            case PokemonType.Dragon:
                switch (other)
                {
                    case PokemonType.Normal:
                        return effectNormal;
                    case PokemonType.Fire:
                        return effectNormal;
                    case PokemonType.Water:
                        return effectNormal;
                    case PokemonType.Electric:
                        return effectNormal;
                    case PokemonType.Grass:
                        return effectNormal;
                    case PokemonType.Ice:
                        return effectNormal;
                    case PokemonType.Fighting:
                        return effectNormal;
                    case PokemonType.Poison:
                        return effectNormal;
                    case PokemonType.Ground:
                        return effectNormal;
                    case PokemonType.Flying:
                        return effectNormal;
                    case PokemonType.Psychic:
                        return effectNormal;
                    case PokemonType.Bug:
                        return effectNormal;
                    case PokemonType.Rock:
                        return effectNormal;
                    case PokemonType.Ghost:
                        return effectNormal;
                    case PokemonType.Dragon:
                        return effectSuper;
                }
                break;
        }

        throw new Exception($"{ty} had no case for {other}");
    }
}
