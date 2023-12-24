using GuessTheNumber.Interfaces;
namespace GuessTheNumber.Controllers.GameLogic;
internal class Randomizer : IRandomizer
{
    private readonly Random _random;
    public Randomizer()
    {
        _random = new Random();
    }
    public int GenerateRandomNumber(int rangeFrom, int rangeTo)
    {
        if (rangeFrom >= rangeTo)
        {
            throw new ArgumentException("Invalid range: rangeFrom must be less than rangeTo");
        }
        return _random.Next(rangeFrom, rangeTo + 1);
    }
}