using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene7 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Dezaktywacja eksperymentu przywraca ci część wspomnień i odkrywasz, że jesteś częścią nielegalnego projektu mającego na celu kontrolowanie ludzi. Znajdujesz wyjście z budynku i uciekasz w noc, ale Twoja wolność jest zawsze zagrożona.\r\nZakończenie: Ucieczka Udaje ci się uciec z miejsca eksperymentu, ale zawsze będziesz żyć w cieniu tajemnic i niepewności o przyszłość.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
