using k9classifier_webapi.Entities;

namespace k9classifier_webapi.Repositories;

public class DogRepository : IDogRepository
{
    private readonly List<Dog> _dogs = new List<Dog>();

    public async Task<Dog> GetDogByIdAsync(int id)
    {
        return _dogs.FirstOrDefault(dog => dog.Id == id);
    }

    public async Task<IEnumerable<Dog>> GetAllDogsAsync()
    {
        return _dogs;
    }

    public async Task AddDogAsync(Dog dog)
    {
        _dogs.Add(dog);
    }

    public async Task UpdateDogAsync(Dog dog)
    {
        var existingDog = await GetDogByIdAsync(dog.Id);
        if (existingDog != null)
        {
            _dogs.Remove(existingDog);
            _dogs.Add(dog);
        }
    }

    public async Task DeleteDogAsync(int id)
    {
        var existingDog = await GetDogByIdAsync(id);
        if (existingDog != null)
        {
            _dogs.Remove(existingDog);
        }
    }
}
