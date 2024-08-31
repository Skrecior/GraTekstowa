using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene22 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Decydujesz się zignorować dokumenty i kontynuować poszukiwanie wyjścia z budynku. Przemieszczasz się przez opuszczone korytarze, które zdają się coraz bardziej zawiłe i niepokojące. Po pewnym czasie odkrywasz drzwi, które prowadzą na zewnątrz, ale są zamknięte.");
        Console.WriteLine("1. Spróbuj otworzyć drzwi, używając dostępnych narzędzi.");
        Console.WriteLine("2. Szukaj alternatywnego wyjścia w budynku.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene23();
            case "2":
                return new Scene24();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
