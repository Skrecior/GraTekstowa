using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene18 : Scene
{
    public override void Display()
    {
        Console.WriteLine(" Drabina prowadzi do ciemnego korytarza. Wchodzisz na górę i odkrywasz, że jesteś w opuszczonym budynku. Znalazłeś wyjście, ale nie jesteś pewien, co czeka cię na zewnątrz.");
        Console.WriteLine("1. Opuść budynek.");
        Console.WriteLine("2. Przeszukaj budynek w poszukiwaniu odpowiedzi.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene19();
            case "2":
                return new Scene20();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
