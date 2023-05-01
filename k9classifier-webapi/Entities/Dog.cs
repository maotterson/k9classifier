namespace k9classifier_webapi.Entities;

public class Dog
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Breed { get; set; } = null!;
}