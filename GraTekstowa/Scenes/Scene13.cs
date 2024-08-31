using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene13 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Używając urządzenia i notatnika, udaje ci się dezaktywować eksperyment. W miarę jak mechanizmy zaczynają się wyłączać, odzyskujesz część swoich wspomnień i orientujesz się, że eksperyment miał na celu kontrolowanie pamięci i tożsamości uczestników. Zyskujesz możliwość ucieczki z piwnicy i odkrycia prawdy o sobie.\r\nZakończenie: Ucieczka Udaje ci się wyjść z budynku, odzyskując część wspomnień. Otrzymujesz szansę na odbudowanie swojego życia, ale wciąż pozostaje pytanie, jakie niebezpieczeństwa mogą czekać na ciebie w świecie poza tymi murami.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
