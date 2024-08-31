using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene20 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Przeszukując budynek, odkrywasz dokumenty dotyczące tajemniczego projektu. Raporty wskazują na mroczne eksperymenty i manipulację pamięcią. W jednym z dokumentów znajduje się zapis: \"Przetrwanie wymaga wyboru.\"\r\n");
        Console.WriteLine("1. Przebadaj mroczne eksperymenty.");
        Console.WriteLine("2. Zignoruj dokumenty i poszukaj innego wyjścia.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene21();
            case "2":
                return new Scene22();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
