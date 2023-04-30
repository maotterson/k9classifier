using k9classifier_webapi.Repositories;

namespace k9classifier_webapi_tests.Repositories;
public class DogRepositoryTests
{
    [Fact]
    public void GetDogById_ReturnsDog_WhenDogExists()
    {
        // Arrange
        var repository = new DogRepository();

        // Act
        var dog = repository.GetDogById(1);

        // Assert
        Assert.NotNull(dog);
        Assert.Equal("Fido", dog.Name);
        Assert.Equal("Husky", dog.Breed);
    }
}