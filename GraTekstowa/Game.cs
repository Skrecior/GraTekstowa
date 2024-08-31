using GraTekstowa.Scenes.Abstractions;
using GraTekstowa.Scenes;

namespace GraTekstowa;

public class Game
{
    public void Start()
    {
        bool playAgain = true;

        while (playAgain)
        {
            Scene currentScene = new Scene1();
            while (currentScene != null)
            {
                currentScene.Display();
                currentScene = currentScene.GetNextScene();
            }

            Console.WriteLine("Gra zakończona.");

            Console.WriteLine("Czy chcesz zagrać ponownie? (tak/nie)");
            string response = Console.ReadLine().Trim().ToLower();

            if (response != "tak")
            {
                playAgain = false;
            }
        }

        Console.WriteLine("Dziękujemy za grę!");
    }
}
