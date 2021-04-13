using System.Collections.Generic;
using System.Linq;
using MVCRestaurant.Data.Models;

namespace MVCRestaurant.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> _restaurants;

        public InMemoryRestaurantData()
        {
            _restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Pizza", Cuisine = CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Spaghetti", Cuisine = CuisineType.French},
                new Restaurant { Id = 3, Name = "Mango", Cuisine = CuisineType.Indian},
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return _restaurants.OrderBy(r => r.Name);
        }
    }
}
