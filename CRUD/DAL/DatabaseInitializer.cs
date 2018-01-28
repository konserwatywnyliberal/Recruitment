using CRUD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD.DAL
{
    public class DatabaseInitializer : CreateDatabaseIfNotExists<CrudContext>
    {
        protected override void Seed(CrudContext context)
        {
            IList<City> defaultCities = new List<City>();
            IList<Person> defaultPersons = new List<Person>();
            IList<Product> defaultProducts = new List<Product>();

            defaultCities.Add(new City() { Id = 1, Name = "Mysłowice", PostalCode = "41-400" });
            defaultCities.Add(new City() { Id = 2, Name = "Siemianowice Śląskie", PostalCode = "41-100" });
            defaultCities.Add(new City() { Id = 3, Name = "Katowice", PostalCode = "40-001" });
            defaultCities.Add(new City() { Id = 4, Name = "Warszawa", PostalCode = "00-001" });

            defaultPersons.Add(new Person() { Id = 1, FirstName = "Piotr", LastName = "Kucharski", Address = "Mysłowice 41-400 ul. Wyspiańskiego" });
            defaultPersons.Add(new Person() { Id = 2, FirstName = "Wojciech", LastName = "Imiołczyk", Address = "Siemianowice Śląskie 41-100 ul. Komuny Paryskiej" });
            defaultPersons.Add(new Person() { Id = 3, FirstName = "Rafał", LastName = "Stochel", Address = "Kraków 31-807 ul. Józefa Strusia" });
            defaultPersons.Add(new Person() { Id = 4, FirstName = "Jan", LastName = "Nowak", Address = "Warszawa 00-001 ul. Kwiatowa" });

            defaultProducts.Add(new Product() { Id = 1, Category = "Sprzęt elektroniczny", Name = "Laptop", Price = 2000M });
            defaultProducts.Add(new Product() { Id = 2, Category = "Sprzęt elektroniczny", Name = "Komputer stacjonarny", Price = 1500M });
            defaultProducts.Add(new Product() { Id = 3, Category = "Sprzęt elektroniczny", Name = "Radio przenośne", Price = 500M });
            defaultProducts.Add(new Product() { Id = 4, Category = "Sprzęt elektroniczny", Name = "Telewizor", Price = 5000M });
            defaultProducts.Add(new Product() { Id = 5, Category = "Samochód", Name = "Alfa romeo Giuilietta", Price = 130000M });
            defaultProducts.Add(new Product() { Id = 6, Category = "Samochód", Name = "Aston Martin DB9", Price = 10000000M });
            defaultProducts.Add(new Product() { Id = 7, Category = "Meble", Name = "Kanapa", Price = 700M });
            defaultProducts.Add(new Product() { Id = 8, Category = "Meble", Name = "Łóżko", Price = 1200M });
            defaultProducts.Add(new Product() { Id = 9, Category = "Meble", Name = "Stolik", Price = 300M });
            defaultProducts.Add(new Product() { Id = 10, Category = "Art. Spożywcze", Name = "Ananas", Price = 7M });
            defaultProducts.Add(new Product() { Id = 11, Category = "Art. Spożywcze", Name = "Gruszka", Price = 2M });
            defaultProducts.Add(new Product() { Id = 12, Category = "Art. Spożywcze", Name = "Chleb", Price = 3.80M });
            defaultProducts.Add(new Product() { Id = 13, Category = "Art. Spożywcze", Name = "Mleko", Price = 4M });
            defaultProducts.Add(new Product() { Id = 14, Category = "Art. Spożywcze", Name = "Masło", Price = 10M });

            foreach (City city in defaultCities)
            {
                context.Cities.Add(city);
            }
            foreach (Person person in defaultPersons)
            {
                context.Persons.Add(person);
            }
            foreach (Product product in defaultProducts)
            {
                context.Products.Add(product);
            }
        }
    }
}