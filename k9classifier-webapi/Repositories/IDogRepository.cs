using k9classifier_webapi.Entities;

namespace k9classifier_webapi.Repositories;

public interface IDogRepository
{
    Dog GetDogById(int id);
    IEnumerable<Dog> GetAllDogs();
    void AddDog(Dog dog);
    void UpdateDog(Dog dog);
    void DeleteDog(int id);
}