using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene8 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Artefakty okazują się być częścią mrocznej magii. Używając ich, odblokowujesz w sobie ukryte moce, które pozwalają ci zniszczyć pułapki i znaleźć drogę do wyjścia. Ostatecznie jednak, stajesz się częścią mrocznego świata.\r\nZakończenie: Integracja z Cieniem Zyskujesz kontrolę nad mrocznymi mocami, ale zostajesz na zawsze związany z cieniami, żyjąc w świecie, gdzie nigdy nie znajdziesz pełnej wolności.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
