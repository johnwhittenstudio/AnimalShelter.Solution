using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
  public class AnimalShelterContext : DbContext
  {
    public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Rose", Species = "Cat", Age = 2, Gender = "Female" },
            new Animal { AnimalId = 2, Name = "Doja", Species = "Cat", Age = 2, Gender = "Female" },
            new Animal { AnimalId = 3, Name = "Elfreda", Species = "Cat", Age = 4, Gender = "Female" },
            new Animal { AnimalId = 4, Name = "Monah", Species = "Cat", Age = 5, Gender = "Female" },
            new Animal { AnimalId = 5, Name = "Eiza", Species = "Cat", Age = 2, Gender = "Female" },
            new Animal { AnimalId = 6, Name = "Norm", Species = "Cat", Age = 7, Gender = "Male" },
            new Animal { AnimalId = 7, Name = "George", Species = "Cat", Age = 2, Gender = "Male" },
            new Animal { AnimalId = 8, Name = "Vlad", Species = "Cat", Age = 13, Gender = "Male" },
            new Animal { AnimalId = 9, Name = "Neuman", Species = "Cat", Age = 3, Gender = "Male" },
            new Animal { AnimalId = 10, Name = "Addy", Species = "Cat", Age = 3, Gender = "Male" }
        );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}