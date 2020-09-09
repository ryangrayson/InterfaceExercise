using System;
namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }

        public bool Is4x4 { get; set; }
        public int BedLength { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsManual { get; set; }
        public string CompanyName { get; set; }
        public bool HasDealership { get; set; }
        public bool HasFreeCoffee { get; set; }
    }
}
