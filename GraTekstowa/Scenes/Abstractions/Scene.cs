namespace GraTekstowa.Scenes.Abstractions;

public abstract class Scene
{
    public abstract void Display();
    public abstract Scene GetNextScene();
}
