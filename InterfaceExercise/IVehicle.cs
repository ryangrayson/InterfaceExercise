using System;
namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumberOfWheels { get; set; }
        public int NumberOfDoors  { get; set; }
        public int NumberOfSeats { get; set; }
        public bool IsManual { get; set; }


    }
}
