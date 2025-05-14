using DogsApp.MVC.Models;

namespace DogsApp.MVC.Services;

public class DogService
{
    private List<Dog> dogs = new List<Dog>();

    public DogService()
    {
        dogs.Add(new Dog { Id = 1, Name = "Rex", Age = 5 });
        dogs.Add(new Dog { Id = 2, Name = "Buddy", Age = 3 });
        dogs.Add(new Dog { Id = 3, Name = "Max", Age = 4 });
    }

    public void AddDog(Dog dog)
    {
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
