public abstract class GameCharacter
{
    public required string CharacterName { get; set; }
    public required string Origin { get; set; }
    public required string Occupation { get; set; }

    public void SayName()
    {
        Console.WriteLine($"Name: {CharacterName}, Origin: {Origin}, Occupation: {Occupation}");
    }
}