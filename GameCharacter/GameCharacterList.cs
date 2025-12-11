using System.Collections.Generic;

public class GameCharacterList
{
    public List<GameCharacter> Characters { get; set; }

    public GameCharacterList()
    {
        Characters = new List<GameCharacter>();
    }

    public void Add(GameCharacter Character)
    {
        Characters.Add(Character);
    }
}