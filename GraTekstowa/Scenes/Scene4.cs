using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene4 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Szukając cieni, odkrywasz małe, ukryte przejście w ścianie. Wchodzisz do niego, ale okazuje się, że jest pułapką. Zostajesz uwięziony w ciemnym tunelu bez wyjścia.\r\nZakończenie: Zatracenie Zostajesz uwięziony w mrocznym tunelu, bez możliwości wydostania się na powierzchnię. Twoja pamięć i tożsamość zostają na zawsze utracone.\r\n");
    }

    public override Scene GetNextScene()
        => null;
}
