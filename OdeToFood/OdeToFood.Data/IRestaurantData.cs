﻿using OdeToFood.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        IEnumerable<Restaurant> GetAll();
    }

    public class InMemoryRestaurantData : IRestaurantData
    {
        readonly List<Restaurant> restaurants;
        public InMemoryRestaurantData()
        {
            restaurants = new List<Restaurant>()
            {
                new Restaurant { Id = 1, Name = "Scott's Pizza", Location="Maryland", Cuisine=CuisineType.Italian},
                new Restaurant { Id = 2, Name = "Pablo's Pizza", Location="Madrid", Cuisine=CuisineType.Mexican},
                new Restaurant { Id = 3, Name = "Ghandi's Pizza", Location="New Dheli", Cuisine=CuisineType.Indian}
            };
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return from r in restaurants
                   orderby r.Name
                   select r;
        }
    }
}
