using Etude.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Etude.Services
{
    public class DataService
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

        public ObservableCollection<FoodGroup> GetFoodGroups()
        {
            return new ObservableCollection<FoodGroup>
            {
                new FoodGroup("Carbohydrates")
                {
                    new Food { Name = "pasta", Description = "Carb Snakes" },
                    new Food { Name = "potato", Description = "The King of all Carbs" },
                    new Food { Name = "bread", Description = "Soft & Gentle" },
                    new Food { Name = "rice", Description = "Tiny grains of goodness" },
                },
                new FoodGroup("Fruits")
                {
                    new Food { Name = "apple", Description = "Keep the Doctor away" },
                    new Food { Name = "banana", Description = "This fruit is appealing" },
                    new Food { Name = "pear", Description = "Pear with me" },
                },
                new FoodGroup("Vegetables")
                {
                    new Food { Name = "carrot", Description = "Sounds like parrot" },
                    new Food { Name = "green bean", Description = "The less popular cousin of the baked bean" },
                    new Food { Name = "broccoli", Description = "Tiny food trees" },
                    new Food { Name = "peas", Description = "Peas sir, can I have some more?" },
                },
                new FoodGroup("Dairy")
                {
                    new Food { Name = "Milk", Description = "Milk" },
                    new Food { Name = "Cheese", Description = "Cheese + Potato" },
                    new Food { Name = "Ice Cream", Description = "Because I couldn't find an icon for yoghurt" }
                }
            };
        }

        public ObservableCollection<Band> GetBands()
        {
            return new ObservableCollection<Band>
            {
                new Band
                {
                    Name = "Black Sabbath",
                    Musicians = new List<string>
                    {
                        "Ozzy Osbourne",
                        "Tommy Iommy",
                        "Geezer Butler",
                        "Bill Ward"
                    }
                },
                new Band
                {
                    Name = "Pink Floyd",
                    Musicians = new List<string>
                    {
                        "Roger Waters",
                        "David Gilmour",
                        "Richard Wright",
                        "Nick Mason"
                    }
                },
                new Band
                {
                    Name = "Led Zeppelin",
                    Musicians = new List<string>
                    {
                        "Robert Plant",
                        "Jimmy Page",
                        "John Paul Jones",
                        "John Bonham"
                    }
                },
                new Band
                {
                    Name = "Deep Purple",
                    Musicians = new List<string>
                    {
                        "Ian Gillan",
                        "Ritchie Blackmore",
                        "Jon Lord",
                        "Roger Glover",
                        "Ian Paice"
                    }
                },
                new Band
                {
                    Name = "Rainbow",
                    Musicians = new List<string>
                    {
                        "Ronnie James Dio",
                        "Ritchie Blackmore",
                        "Jimmy Bain",
                        "Tony carey",
                        "Cozy Powell"
                    }
                }
            };
        }
    }
}
