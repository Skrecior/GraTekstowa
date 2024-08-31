using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene15 : Scene
{
    public override void Display()
    {
        Console.WriteLine(" Lampa naftowa rzuca delikatne światło w piwnicy. W blasku lampy dostrzegasz dwa miejsca: ukryte drzwi za drewnianą skrzynią i starą, zniszczoną drabinę prowadzącą do wyjścia.\r\n");
        Console.WriteLine("1. Zbadaj ukryte drzwi.");
        Console.WriteLine("2. Wejdź po drabinie.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene16();
            case "2":
                return new Scene18();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
