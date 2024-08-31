using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene11 : Scene
{
    public override void Display()
    {
        Console.WriteLine("W miarę jak piwnica zmienia się w zaskakujący sposób, znajdujesz ukryte przejście w ścianie, które prowadzi do innego tunelu. Po przejściu przez tunel, odkrywasz wyjście, które prowadzi do zewnętrznego, zrujnowanego miasta. Zjawisko w piwnicy było próbą utrzymania cię w miejscu — twoja decyzja o powrocie do piwnicy uniemożliwiła ci skorzystanie z możliwości dezaktywacji.\r\nZakończenie: Zatracenie Udaję się na zewnątrz do nieznanego, opustoszałego świata. Twoja decyzja o ignorowaniu dezaktywacji eksperymentu sprawia, że nigdy nie odkrywasz pełnej prawdy o sobie i pozostajesz w mrocznym świecie pełnym niebezpieczeństw i niepewności.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
