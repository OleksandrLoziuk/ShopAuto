using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get; }
        IEnumerable<Car> GetFavCars { get; }
        Car GetOjectCar(int carId);
    }
}
