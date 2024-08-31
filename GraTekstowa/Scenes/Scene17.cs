using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene17 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Podczas poszukiwań klucza, odkrywasz, że piwnica jest pełna śladów niebezpiecznych pułapek. Zatrzymujesz się, gdy zauważasz, że każdy ruch może prowadzić do zagrożenia.\r\nZakończenie: Zatracenie Zostajesz uwięziony przez pułapki w piwnicy, bez możliwości odnalezienia klucza i ucieczki. Twoja pamięć i tożsamość znikają na zawsze.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
