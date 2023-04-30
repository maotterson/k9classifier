using k9classifier_webapi.Entities;
using k9classifier_webapi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace k9classifier_webapi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class DogController : ControllerBase
{
    private readonly IDogRepository _repository;

    public DogController(IDogRepository repository)
    {
        _repository = repository;
    }

    [HttpGet]
    public async Task<IEnumerable<Dog>> GetDogsAsync()
    {
        var dogs = await _repository.GetAllDogsAsync();
        return dogs;
    }
}