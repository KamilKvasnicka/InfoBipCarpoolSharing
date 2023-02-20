using KKCarpoolMNGMNT.Interfaces;

namespace KKCarpoolMNGMNT.Models
{
    public class MockCarsRepo : ICarsRepo
    {
        public IEnumerable<Car> Cars => new List<Car>
        {
            new Car { Name = "Mustang for Boss", CarType = "Ford Mustang", Color = "Black", NumberOfSeats = 4, Plates = "AA 999 AA" },
            new Car { Name = "Green Skoda for travel", CarType = "Skoda Octavia", Color = "Green", NumberOfSeats = 5, Plates = "AA 123 AB" },
            new Car { Name = "Fiat for food delivery", CarType = "Fiat Panda", Color = "White", NumberOfSeats = 2, Plates = "AB 210 AC" },
            new Car { Name = "Toyota MR2 for month star", CarType = "Toyota MR2", Color = "Brown", NumberOfSeats = 2, Plates = "AA 216 AB" },
            new Car { Name = "Fiat Ducato Bus", CarType = "Fiat Ducato", Color = "White", NumberOfSeats = 9, Plates = "AA 128 AA" },
            new Car { Name = "Fiat Ducato Van", CarType = "Fiat Ducato", Color = "Silver", NumberOfSeats = 3, Plates = "RV 273 BV" },
            new Car { Name = "Honda Civic for Reception", CarType = "Honda Civic", Color = "Silver", NumberOfSeats = 5, Plates = "RV 780 BX" },
            new Car { Name = "Honda Jazz for HR", CarType = "Honda Jazz", Color = "Blue", NumberOfSeats = 4, Plates = "RV 880 BB" },
            new Car { Name = "Opel Vivaro Bus", CarType = "Opel Vivaro", Color = "Yellow", NumberOfSeats = 8, Plates = "RA 356 CC" },
            new Car { Name = "Mini for secretary", CarType = "Mini Cooper S", Color = "Red", NumberOfSeats = 2, Plates = "RV 222 DD" }
        };

        public IEnumerable<Car> GetCars()
        {
            return Cars;
        }
    }
}
