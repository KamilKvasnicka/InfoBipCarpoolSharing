using KKCarpoolMNGMNT.Interfaces;
using KKCarpoolMNGMNT.Models;

namespace KKCarpoolMNGMNT.Services
{
    public class CarService : ICarService
    {
        private ICarsRepo _carRepository;

        public CarService(ICarsRepo carRepository)
        {
            _carRepository = carRepository;
        }

        public IEnumerable<Car> Cars => _carRepository.GetCars();

        public bool CanFitIntoACar(string licensePlates, List<Employee> selectedEmployees)
        {
            Car car = GetCar(licensePlates);

            if (car != null)
            {
                if (car.NumberOfSeats < selectedEmployees.Count)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public bool CanFitIntoACar(string licensePlates, int[] employeesIds)
        {
            Car car = GetCar(licensePlates);

            if (car != null)
            {
                if (car.NumberOfSeats < employeesIds.Length)
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public Car GetCar(string licensePlates)
        {
            Car car = Cars.Where(c => c.Plates == licensePlates).FirstOrDefault();

            return car;
        }
    }
}
