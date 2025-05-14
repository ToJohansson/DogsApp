using DogsApp.MVC.Models;

namespace DogsApp.MVC.Services;

public class DogService
{
    private List<Dog> dogs = new List<Dog>();

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
