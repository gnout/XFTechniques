using Etude.Models;
using System.Collections.Generic;

namespace Etude.Services
{
    public class FoodService
    {
        public List<Food> GetFoods()
        {
            return new List<Food>
            {
                new Food { Name = "Pasta", Description = "Carb Snakes" },
                new Food { Name = "Potato", Description = "The King of all Carbs" },
                new Food { Name = "Bread", Description = "Soft & Gentle" },
                new Food { Name = "Rice", Description = "Tiny grains of goodness" },
                new Food { Name = "Apple", Description = "Keep the Doctor away" },
                new Food { Name = "Banana", Description = "This fruit is appealing" },
                new Food { Name = "Pear", Description = "Pear with me" },
                new Food { Name = "Carrot", Description = "Sounds like parrot" },
                new Food { Name = "Green Bean", Description = "The less popular cousin of the baked bean" },
                new Food { Name = "Broccoli", Description = "Tiny food trees" },
                new Food { Name = "Peas", Description = "Peas sir, can I have some more?" },
                new Food { Name = "Milk", Description = "Milk" },
                new Food { Name = "Cheese", Description = "Cheese + Potato" },
                new Food { Name = "Ice Cream", Description = "Because I couldn't find an icon for yoghurt" }
            };
        }
    }
}
