using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene25 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Nowe dokumenty ujawniają, że budynek i eksperyment były częścią większego projektu, który miał na celu kontrolowanie ludzkich wspomnień. Znajdujesz plan budynku i informacje o ukrytych wyjściach oraz możliwościach dezaktywacji eksperymentu.");
        Console.WriteLine("1. Postępuj zgodnie z instrukcjami, aby znaleźć bezpieczne wyjście.");
        Console.WriteLine("2. Ignoruj nowe odkrycia i wróć do głównego wyjścia.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene26();
            case "2":
                return new Scene27();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
