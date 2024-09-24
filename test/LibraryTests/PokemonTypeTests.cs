using NUnit.Framework;
using Library.Game;

class Tests
{
    [SetUp]
    public void SetUp()
    {

    }

    [Test]
    public void AdvantageHasValidValue()
    {
        foreach (var v1 in Enum.GetValues<PokemonType>())
        {
            foreach (var v2 in Enum.GetValues<PokemonType>())
            {
                Assert.That(v1.getAdvantage(v2), Is.AnyOf([0.0, 0.5, 1.0, 2.0]));
            }
        }
    }
}
