using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene9 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Decydujesz się opuścić biuro i wrócić do piwnicy. Po drodze zastanawiasz się, czy dobrze zrobiłeś, ignorując możliwość dezaktywacji eksperymentu. Kiedy docierasz do piwnicy, zauważasz, że miejsce to wygląda nieco inaczej — zdaje się, że coś się zmieniło.");
        Console.WriteLine("1. Odwiedź starą skrzynię.");
        Console.WriteLine("2. Przeszukaj piwnicę w poszukiwaniu zmian.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene10();
            case "2":
                return new Scene11();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
