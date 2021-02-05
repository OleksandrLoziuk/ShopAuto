using Shop.Data.Interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars
        {
            get
            {
                return new List<Car>
                {
                    new Car
                    {
                        Name = "Tesla",
                        ShortDesc = "Быстрый автомобиль",
                        LongDesc = "Красивый, быстрый очень тихий автомобиль",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = _categoryCars.AllCategories.First()
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
                        Category = _categoryCars.AllCategories.Last()
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
                        Category = _categoryCars.AllCategories.Last()
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
                        Category = _categoryCars.AllCategories.Last()
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
                        Category = _categoryCars.AllCategories.First()
                    }

                };
            }
        }
        public IEnumerable<Car> GetFavCars { get; set ; }

        public Car GetOjectCar(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
