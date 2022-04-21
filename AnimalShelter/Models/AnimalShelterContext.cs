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
            new Animal { AnimalId = 10, Name = "Addy", Species = "Cat", Age = 3, Gender = "Male" },
            new Animal { AnimalId = 11, Name = "Yoko", 	Species = "Cat", 	Age = 5, 	Gender = "Female" },
            new Animal { AnimalId = 12, Name = "Giselle", Species = "Cat", 	Age = 2, 	Gender = "Female" },
            new Animal { AnimalId = 13, Name = "Dorri", Species = "Cat", 	Age = 7, 	Gender = "Female" },
            new Animal { AnimalId = 14, Name = "Dido", 	Species = "Cat", 	Age = 12, 	Gender = "Female" },
            new Animal { AnimalId = 15, Name = "Selina Kyle",	Species = "Cat", 	Age = 3, 	Gender = "Female" },
            new Animal { AnimalId = 16, Name = "Franklin", 	Species = "Cat", 	Age = 1, 	Gender = "Male" },
            new Animal { AnimalId = 17, Name = "Arney", 	Species = "Cat", 	Age = 5, 	Gender = "Male" },
            new Animal { AnimalId = 18, Name = "Benedicto", 	Species = "Cat", 	Age = 2, 	Gender = "Male" },
            new Animal { AnimalId = 19, Name = "Sammie", 	Species = "Cat", 	Age = 7, 	Gender = "Male" },
            new Animal { AnimalId = 20, Name = "Giraldo", 	Species = "Cat", 	Age = 10, 	Gender = "Male" },
            new Animal { AnimalId = 21, Name = "Chloe", 	Species = "Dog", 	Age = 3, 	Gender = "Female" },
            new Animal { AnimalId = 22, Name = "Dixie", 	Species = "Dog", 	Age = 2, 	Gender = "Female" },
            new Animal { AnimalId = 23, Name = "Neko", 	Species = "Dog", 	Age = 3, 	Gender = "Female" },
            new Animal { AnimalId = 24, Name = "Polly", 	Species = "Dog", 	Age = 5, 	Gender = "Female" },
            new Animal { AnimalId = 25, Name = "Cleo", 	Species = "Dog", 	Age = 7, 	Gender = "Female" },
            new Animal { AnimalId = 26, Name = "Ebeneser", 	Species = "Dog", 	Age = 2, 	Gender = "Male" },
            new Animal { AnimalId = 27, Name = "Ruprecht", 	Species = "Dog", 	Age = 3, 	Gender = "Male" },
            new Animal { AnimalId = 28, Name = "Abrahamster", 	Species = "Dog", 	Age = 12, 	Gender = "Male" },
            new Animal { AnimalId = 29, Name = "Kasper", 	Species = "Dog", 	Age = 5, 	Gender = "Male" },
            new Animal { AnimalId = 30, Name = "Eliot", 	Species = "Dog", 	Age = 1, 	Gender = "Male" },
            new Animal { AnimalId = 31, Name = "Venus", 	Species = "Dog", 	Age = 2, 	Gender = "Female" },
            new Animal { AnimalId = 32, Name = "Tonie", 	Species = "Dog", 	Age = 4, 	Gender = "Female" },
            new Animal { AnimalId = 33, Name = "Daniella", 	Species = "Dog", 	Age = 7, 	Gender = "Female" },
            new Animal { AnimalId = 34, Name = "Amala", 	Species = "Dog", 	Age = 2, 	Gender = "Female" },
            new Animal { AnimalId = 35, Name = "Jolene", 	Species = "Dog", 	Age = 5, 	Gender = "Female" },
            new Animal { AnimalId = 36, Name = "Dwight", 	Species = "Dog", 	Age = 5, 	Gender = "Male" },
            new Animal { AnimalId = 37, Name = "Munroe", 	Species = "Dog", 	Age = 1, 	Gender = "Male" },
            new Animal { AnimalId = 38, Name = "John", 	Species = "Dog", 	Age = 7, 	Gender = "Male" },
            new Animal { AnimalId = 39, Name = "Nils", 	Species = "Dog", 	Age = 10, 	Gender = "Male" },
            new Animal { AnimalId = 40, Name = "Thom", 	Species = "Dog", 	Age = 8, 	Gender = "Male" }
        );
    }

    public DbSet<Animal> Animals { get; set; }
  }
}