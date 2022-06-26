using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {   
            restaurants = new List<Restaurant>()
            {
                new Restaurant{ Id=1, Name="Casa de campm", Cuisine= CuisineType.Bolivian },
                new Restaurant{ Id=2, Name="Solo Pastas", Cuisine= CuisineType.Italian },
                new Restaurant{ Id=3, Name="Burger King", Cuisine= CuisineType.American }
            };
        }

        public Restaurant Get(int id)
        {
            return restaurants.FirstOrDefault(r => r.Id == id);
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurants.OrderBy(r => r.Name);
        }
    }


}
