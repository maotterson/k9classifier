using k9classifier_webapi.Entities;

namespace k9classifier_webapi.Repositories;

public interface IDogRepository
{
    Task<Dog> GetDogByIdAsync(int id);
    Task<IEnumerable<Dog>> GetAllDogsAsync();
    Task AddDogAsync(Dog dog);
    Task UpdateDogAsync(Dog dog);
    Task DeleteDogAsync(int id);
}