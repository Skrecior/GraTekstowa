using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene10 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Skrzynia, którą wcześniej otworzyłeś, jest teraz zamknięta. Wydaje się, że coś się zmieniło w jej wnętrzu. Po jej otwarciu odkrywasz, że klucz i książka, które znalazłeś wcześniej, są teraz niedostępne. Zauważasz, że coś w piwnicy zaczyna się zmieniać — ściany zdają się kurczyć, a światło lampy staje się coraz bardziej słabe.\r\n");
        Console.WriteLine("1. Spróbuj znaleźć nową drogę wyjścia.");
        Console.WriteLine("2. Przeszukaj skrzynię jeszcze raz.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene11();
            case "2":
                return new Scene12();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
