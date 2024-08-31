using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene12 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Przeszukując skrzynię ponownie, zauważasz, że zmieniła się — teraz zawiera dziwne, nowoczesne urządzenie i stary notatnik. Urządzenie wygląda na klucz do systemu, który mogłoby służyć do dekodowania lub dezaktywacji eksperymentu. Notatnik zawiera instrukcje, które mogą pomóc w dekodowaniu urządzenia.\r\n");
        Console.WriteLine("1. Spróbuj użyć urządzenia i notatnika do dezaktywacji eksperymentu.");
        Console.WriteLine("2. Ignoruj urządzenie i notatnik, szukając alternatywnego wyjścia.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene13();
            case "2":
                return new Scene14();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
