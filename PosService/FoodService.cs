using PosModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosService
{
    public class FoodService
    {
        public List<FoodModel> GetFoodItems()
        {
            return new List<FoodModel>
            {
                new FoodModel { Id = 1, Name = "Chicken Biryani", Price = 250.00m, Category = "Main Course" },
                new FoodModel { Id = 2, Name = "Grilled Chicken", Price = 400.00m, Category = "Main Course" },
                new FoodModel { Id = 3, Name = "Mutton Kebab", Price = 350.00m, Category = "Appetizer" },
                new FoodModel { Id = 4, Name = "Paneer Butter Masala", Price = 220.00m, Category = "Vegetarian" },
                new FoodModel { Id = 5, Name = "French Fries", Price = 120.00m, Category = "Snacks" },
                new FoodModel { Id = 6, Name = "Chocolate Brownie", Price = 180.00m, Category = "Dessert" },
                new FoodModel { Id = 7, Name = "Mango Lassi", Price = 90.00m, Category = "Beverage" }
            };
        }
    }
}
