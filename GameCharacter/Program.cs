using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        GameCharacterList liste = new GameCharacterList();

        // Predefined List
        List<string> origins = new List<string> { "Human", "Half-elf", "Elf", "Dwarf", "Halfling", "Gnome", "Half-Ork", "Transformer", "Android", "Shapeshifter", "Kenku", "Minotaur", "Dragonborn", "Genasi", "Zombie", "Skeleton", "Vampire", "Ghost" };
        List<string> occupations = new List<string> { "Barbarian", "Samurai", "Archer", "Monk", "Ninja", "Paladin", "Wizard", "Sorcerer", "Necromancer", "Druid", "Warlock", "Cleric", "Bard", "Blacksmith", "Alchemist" };

        while (true)
        {
            Console.Write("Please, Enter your Characters name. (or 'stop' to print the final list): ");
            string CharacterName = Console.ReadLine() ?? "";

            if (CharacterName.ToLower() == "stop")
                break;

            // Choose Origin
            Console.WriteLine("\nChoose Origin:");
            for (int i = 0; i < origins.Count; i++)
                Console.WriteLine($"{i + 1}. {origins[i]}");

            int originChoice = ChooseFromList(origins.Count);

            // Choose Occupation
            Console.WriteLine("\nChoose Occupation:");
            for (int i = 0; i < occupations.Count; i++)
                Console.WriteLine($"{i + 1}. {occupations[i]}");

            int occupationChoice = ChooseFromList(occupations.Count);

            // Create Character
            GameCharacter Character = new GameCharacter
            {
                CharacterName = CharacterName,
                Origin = origins[originChoice - 1],
                Occupation = occupations[occupationChoice - 1]
            };

            liste.Add(Character);
            Console.WriteLine("Character Added!\n");
        }

        // Print Characterlist
        Console.WriteLine("\n--- YOUR CHARACTERS ---");
        foreach (var k in liste.Characters)
        {
            Console.WriteLine($"Name: {k.CharacterName}, Origin: {k.Origin}, Occupation: {k.Occupation}");
        }
    }

    static int ChooseFromList(int amount)
    {
        int Choice;
        while (true)
        {
            Console.Write("Enter number: ");
            if (int.TryParse(Console.ReadLine(), out Choice) && Choice >= 1 && Choice <= amount)
                return Choice;

            Console.WriteLine("Invalid choice – try again.");
        }
    }
}