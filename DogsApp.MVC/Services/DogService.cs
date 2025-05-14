using DogsApp.MVC.Models;

namespace DogsApp.MVC.Services;

public class DogService
{
    private List<Dog> dogs = new List<Dog>();
    private int nextId;
    private int NextId { get{ return nextId++; } set { value = nextId; } } 
    public DogService()
    {
        dogs.Add(new Dog { Id = NextId, Name = "Rex", Age = 5 });
        dogs.Add(new Dog { Id = NextId, Name = "Buddy", Age = 3 });
        dogs.Add(new Dog { Id = NextId, Name = "Max", Age = 4 });
    }

    public void AddDog(Dog dog)
    {
        dog.Id = NextId;
        dogs.Add(dog);
    }
    public Dog[] GetAllDogs()
    {

        return dogs.ToArray();
    }
    public Dog GetDogById(int id)
    {
        return dogs.Single(d => d.Id == id);
    }
}
