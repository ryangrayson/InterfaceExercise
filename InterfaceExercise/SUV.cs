using System;
namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }
        public bool Has3rdRowSeat { get; set; }
        public bool HasCargoRack { get; set; }
        public int NumberOfWheels { get ; set ; }
        public int NumberOfDoors { get ; set ; }
        public int NumberOfSeats { get ; set ; }
        public bool IsManual { get ; set ; }
        public string CompanyName { get ; set ; }
        public bool HasDealership { get ; set ; }
        public bool HasFreeCoffee { get ; set ; }
    }
}
