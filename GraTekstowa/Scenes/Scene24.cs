using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene24 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Decydujesz się poszukać alternatywnego wyjścia w budynku. Przeszukując dalsze zakamarki, natrafiasz na ukryte przejście prowadzące do piwnicy, której wcześniej nie zauważyłeś. W piwnicy znajdujesz kolejne dokumenty i artefakty, które mogą dostarczyć cennych informacji na temat eksperymentu.");
        Console.WriteLine("1. Przebadaj nowe dokumenty i artefakty.");
        Console.WriteLine("2. Zignoruj dokumenty i spróbuj znaleźć inne wyjście.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene25();
            case "2":
                return new Scene27();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
