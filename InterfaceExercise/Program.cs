using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany--DONE

            //Create 3 classes called Car , Truck , & SUV--DONE

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */
            //---DONE


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */
            //---DONE

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size--DONE
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */
            //---DONE

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var mustang = new Car()
            {
                HasDealership = true,
                HasFreeCoffee = false,
                HasTrunk = false,
                IsConvertible = false,
                IsManual = true,
                CompanyName = "Ford",
                NumberOfDoors = 2,
                NumberOfSeats = 2,
                NumberOfWheels = 4
            };
            Console.WriteLine($"Mustang======================" +
                $"\nCan buy off lot?: {mustang.HasDealership}" +
                $"\nFree Coffee at dealership?: {mustang.HasFreeCoffee}" +
                $"\nHas a trunk: {mustang.HasTrunk}" +
                $"\nConvertible?: {mustang.IsConvertible}" +
                $"\nManual Transmission: {mustang.IsManual}" +
                $"\nNumber of doors: {mustang.NumberOfDoors}" +
                $"\nNumber of seats: {mustang.NumberOfSeats}" +
                $"\nNumber of wheels: {mustang.NumberOfWheels}");
            Console.WriteLine("==============================");
               
            var tacoma = new Truck();
            tacoma.NumberOfWheels = 4;
            tacoma.NumberOfSeats = 5;
            tacoma.NumberOfDoors = 4;
            tacoma.IsManual = false;
            tacoma.Is4x4 = true;
            tacoma.CompanyName = "Toyota";
            tacoma.HasDealership = true;
            tacoma.HasFreeCoffee = true;
            tacoma.BedLength = 62;


            var escape = new SUV()
            {
                HasDealership = true,
                HasFreeCoffee = true,
                IsManual = false,
                NumberOfDoors = 4,
                NumberOfSeats = 5,
                NumberOfWheels = 4,
                CompanyName = "Ford",
                Has3rdRowSeat = false,
                HasCargoRack = true
            };



            



                


                
           
            



            //var vehicles = new List<IVehicle>() { car, truck, suv };

            //foreach (var vehicle in vehicles)
            //{
            //    vehicle.
            //}







        }
    }
}
