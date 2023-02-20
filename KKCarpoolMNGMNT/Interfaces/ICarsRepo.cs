using KKCarpoolMNGMNT.Models;

namespace KKCarpoolMNGMNT.Interfaces
{
    public interface ICarsRepo
    {
        IEnumerable<Car> GetCars();
    }
}
