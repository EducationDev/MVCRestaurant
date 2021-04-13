using System.Collections.Generic;
using MVCRestaurant.Data.Models;

namespace MVCRestaurant.Data.Services
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }
}
