using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;


namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {

            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));
            if(!content.Car.Any())
            {
                content.AddRange(
                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый очень тихий автомобиль",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    },
                    new Car
                    {
                        Name = "Ford Fiesta",
                        ShortDesc = "Тихий и спокойный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/fiesta.jpg",
                        Price = 11000,
                        IsFavorite = false,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "BMW M3",
                        ShortDesc = "Дерзкий и стильный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/bmw.jpg",
                        Price = 60000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Mercedes S Class",
                        ShortDesc = "Большой и удобный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/mercedes.jpg",
                        Price = 65000,
                        IsFavorite = false,
                        Available = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        Name = "Nissan Leaf",
                        ShortDesc = "Бесшумный и экономный",
                        LongDesc = "Удобный автомобиль для городской жизни",
                        Img = "/img/leaf.jpg",
                        Price = 14000,
                        IsFavorite = true,
                        Available = true,
                        Category = Categories["Электромобили"]
                    }
                    );
            }
            content.SaveChanges();
        }
        private static Dictionary<string, Category> Category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if(Category==null)
                {
                    var list = new Category[]
                    {
                        new Category {CategoryName = "Электромобили", Desc ="Современный вид транспорта" },
                        new Category {CategoryName = "Классические автомобили", Desc = "Машины с двигателем внутреннего згорания"}
                    };
                    Category = new Dictionary<string, Category>();
                    foreach(Category el in list)
                    {
                        Category.Add(el.CategoryName, el);
                    }
                }
                return Category;
            }
        }
    }
}
