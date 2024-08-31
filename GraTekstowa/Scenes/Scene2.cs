using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene2 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Skrzynia zawiera książkę w oprawie ze skóry oraz mały klucz. Kiedy bierzesz klucz do ręki, w pomieszczeniu zaczynasz słyszeć dziwne szumy, jakby coś się zbliżało.");
        Console.WriteLine("1. Przeczytaj książkę.");
        Console.WriteLine("2. Użyj klucza na zardzewiałym zamku przy ścianie.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene3();
            case "2":
                 return new Scene5();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}

