namespace k9classifier_webapi.Repositories;

public interface IDogRepository
{
    IEnumerable<string> GetDogNames();
}