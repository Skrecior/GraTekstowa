using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene19 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Opuściwszy budynek, odkrywasz, że jesteś w zrujnowanym mieście, które wygląda na porzucone. Wszędzie panuje cisza i mrok, a twoja wolność jest ograniczona przez nieznane niebezpieczeństwa.\r\nZakończenie: Ucieczka Udaje ci się wydostać z budynku, ale pozostajesz w niepewności co do tego, co czai się w mrocznym świecie na zewnątrz.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
