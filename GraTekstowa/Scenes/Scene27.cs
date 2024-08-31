using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene27 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Wracasz do głównego wyjścia, ale drzwi są teraz zablokowane lub zastawione. Przez brak pełnej informacji o eksperymencie i nieodpowiednie decyzje w poszukiwaniu wyjścia, jesteś teraz uwięziony.\r\nZakończenie: Zatracenie Twoje decyzje prowadzą do tego, że zostajesz uwięziony w budynku, który zamienia się w pułapkę. Brak pełnej wiedzy i błędne decyzje skutkują tym, że pozostajesz w mrocznych cieniach budynku, z którymi musisz się zmierzyć.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
