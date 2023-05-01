using k9classifier_webapi.Entities;
using k9classifier_webapi.Repositories;
using Moq;

namespace k9classifier_webapi_tests.Repositories;
public class DogRepositoryTests
{ 
    private readonly Mock<IDogRepository> _mockRepository;

    public DogRepositoryTests()
    {
        _mockRepository = new Mock<IDogRepository>();
        _mockRepository.Setup(repo => repo.GetDogByIdAsync(1))
                       .Returns(Task.FromResult(new Dog { Id = 1, Name = "Winnie", Breed = "Siberian Husky" }));
    }

    [Fact]
    public async Task GetById_WithValidId_ReturnsCorrectDog()
    {
        // Arrange
        var repository = _mockRepository.Object;

        // Act
        var result = await repository.GetDogByIdAsync(1);

        // Assert
        Assert.NotNull(result);
        Assert.Equal(1, result.Id);
        Assert.Equal("Winnie", result.Name);
        Assert.Equal("Siberian Husky", result.Breed);
    }
}