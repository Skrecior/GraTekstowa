using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene16 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Ukryte drzwi są zamknięte na solidny zamek. Wydaje się, że bez klucza nie będziesz w stanie ich otworzyć. W piwnicy nie ma jednak żadnych śladów klucza ani narzędzi.");
        Console.WriteLine("1. Poszukaj klucza w piwnicy.");
        Console.WriteLine("2. Wróć do drabiny i spróbuj opuścić piwnicę.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene17();
            case "2":
                return new Scene18();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
