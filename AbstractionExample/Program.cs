
Animal dog = new Dog();
dog.Name = "dog";
Animal cat = new Cat();
cat.Name = "cat";
dog.MakeSound();
cat.MakeSound();
TryFetch(dog, "stick");
TryClimb(cat, "tree");
TryFetch(cat, "stick");
TryClimb(dog, "tree");
void TryFetch(Animal a, string fetchable)
{
    if(a is IFetcher fetcher)
    {
        fetcher.FetchObject(fetchable);
    }
    else
    {
        Console.WriteLine(a.Name + " can't do that!");
    }
}

void TryClimb(Animal a, string climbable)
{
    if(a is IClimber climber)
    {
        climber.ClimbObject(climbable);
    }
    else
    {
        Console.Write(a.Name + " can't do that!");
    }
}
interface IClimber { public void ClimbObject(string climbable); }

interface IFetcher { public void FetchObject(string fetchable); }

public interface IAnimal
{
    string? Name { get; set; }
    void MakeSound();
}
public abstract class Animal : IAnimal
{
    public string? Name { get; set; }
    public virtual void MakeSound()
    {
        Console.WriteLine("Default noise");
    }
}
//By making abstract Animal extend interface IAnimal
//We can force child classes to include MakeSound()+Name

public class Dog : Animal, IFetcher
{
    public override void MakeSound()
    {
        Console.WriteLine("Woof!");
    }
    public void FetchObject(string fetchable)
    {
        Console.WriteLine("Fetches the " + fetchable);
    }
}

public class Cat : Animal, IClimber
{
    public override void MakeSound()
    {
        Console.WriteLine("Meow!");
    }
    public void ClimbObject(string climbable)
    {
        Console.WriteLine("Climbs the " + climbable);
    }
}