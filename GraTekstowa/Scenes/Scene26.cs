using GraTekstowa.Scenes.Abstractions;

namespace GraTekstowa.Scenes;

public class Scene26 : Scene
{
    public override void Display()
    {
        Console.WriteLine("Postępując zgodnie z instrukcjami, znajdujesz ukryte wyjście, które prowadzi do bezpieczniejszej części miasta. Możesz teraz odzyskać część swoich wspomnień i zrozumieć, co się stało, ale wciąż pozostają pytania o pełną prawdę.\r\nZakończenie: Ucieczka Odnajdujesz bezpieczne miejsce i możliwość odbudowy, ale nadal musisz zmierzyć się z mrokiem przeszłości i możliwymi konsekwencjami eksperymentu.\r\n");
    }

    public override Scene GetNextScene()
    => null;
}
