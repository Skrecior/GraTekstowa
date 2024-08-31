using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene6 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Dokumenty zawierają informacje o eksperymentach związanych z manipulacją pamięcią. Ostatni raport mówi, że jesteś częścią eksperymentu mającego na celu usunięcie wspomnień i tożsamości. Znajdujesz sposób na dezaktywację eksperymentu.");
        Console.WriteLine("1. Aktywuj dezaktywację.");
        Console.WriteLine("2. Opuść biuro i wróć do piwnicy.");
    }

    public override Scene GetNextScene()
    {
        string choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return new Scene7();
            case "2":
                return new Scene9();
            default:
                Console.WriteLine("Wybór nieprawidłowy.");
                return this;
        }
    }
}
