using k9classifier_webapi.Entities;

namespace k9classifier_webapi.Repositories;

public class DogRepository : IDogRepository
{
    private readonly List<Dog> _dogs = new List<Dog>();

    public Dog GetDogById(int id)
    {
        return _dogs.FirstOrDefault(dog => dog.Id == id);
    }

    public IEnumerable<Dog> GetAllDogs()
    {
        return _dogs;
    }

    public void AddDog(Dog dog)
    {
        _dogs.Add(dog);
    }

    public void UpdateDog(Dog dog)
    {
        var existingDog = GetDogById(dog.Id);
        if (existingDog != null)
        {
            _dogs.Remove(existingDog);
            _dogs.Add(dog);
        }
    }

    public void DeleteDog(int id)
    {
        var existingDog = GetDogById(id);
        if (existingDog != null)
        {
            _dogs.Remove(existingDog);
        }
    }
}
