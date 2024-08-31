using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene23 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Używasz narzędzi, które znalazłeś w budynku, aby sforsować drzwi. Po ich otwarciu wychodzisz na zewnątrz i odkrywasz, że znajdujesz się w zrujnowanym, opustoszałym świecie. Miasto wygląda na całkowicie zniszczone, a cisza jest przytłaczająca. Nie ma żadnych oznak życia w pobliżu.\r\nZakończenie: Ucieczka Udaje ci się opuścić budynek, ale znajdujesz się w nieznanym i przerażającym świecie, który może być pełen niebezpieczeństw i tajemnic. Twoje decyzje sprawiły, że nie odkryłeś pełnej prawdy o sobie, a mrok świata zewnętrznego może okazać się jeszcze bardziej przerażający.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
