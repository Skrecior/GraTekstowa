using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene14 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Decydujesz się zignorować nowe odkrycia w skrzyni i wracasz do głównego wyjścia. Niestety, przez brak pełnej informacji i próbę ucieczki bez pełnej aktywacji dezaktywacji eksperymentu, trafiasz na nowe pułapki i trudności w budynku.\r\nZakończenie: Zatracenie Wracając do głównego wyjścia, odkrywasz, że budynek zamienia się w pułapkę. Zostajesz uwięziony w jego mrocznych cieniach, z pozostawionymi pytaniami i straconymi szansami na odzyskanie pełnej tożsamości.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
