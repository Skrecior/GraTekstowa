using GraTekstowa.Scenes.Abstractions;
using System.Data;

namespace GraTekstowa.Scenes;

public class Scene1 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Otwarte oczy odkrywają zimną, wilgotną piwnicę. Niskie sklepienie i ściany pokryte pleśnią tworzą przytłaczający klimat. W rogu dostrzegasz dwie rzeczy: starą, zardzewiałą skrzynię i porzuconą lampę naftową.");
        Console.WriteLine("1. Otwórz skrzynię.");
        Console.WriteLine("2. Weź lampę naftową.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene2();
            case "2":
                return new Scene15();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}

