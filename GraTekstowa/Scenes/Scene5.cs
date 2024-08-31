using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene5 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Klucz pasuje do zamka, który otwiera tajemne drzwi. Za nimi znajduje się mroczne biuro z dokumentami i dziwnymi artefaktami. Na biurku znajduje się notatnik z ostatnim zapisem: \"Prawda znajduje się w miejscu, gdzie nie ma już cieni.\"\r\n");
        Console.WriteLine("1. Przeszukaj dokumenty.");
        Console.WriteLine("2. Użyj artefaktów w pokoju");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene6();
            case "2":
                return new Scene8();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
