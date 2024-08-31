using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene21 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Odkrywasz, że byłeś częścią eksperymentu mającego na celu kontrolowanie pamięci. Znajdujesz sposób na zakończenie eksperymentu, ale poznajesz mroczne sekrety, które zostają z tobą na zawsze.\r\nZakończenie: Integracja z Cieniem Zyskujesz wiedzę o mrocznych eksperymentach, ale pozostajesz związany z cieniami, które wciąż kontrolują twoje życie.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
