using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene3 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Książka jest wypełniona niezrozumiałymi symbolami i tekstami. Na końcu znajduje się zapis: \"Przebudzenie jest pułapką. Klucz do prawdy jest zakryty w cieniach.\"");
        Console.WriteLine("1. Szukaj cieni w piwnicy.");
        Console.WriteLine("2. Użyj klucza na zardzewiałym zamku.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene4();
            case "2":
                return new Scene5();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}

