using System;
using ParkingLot.model;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] value = input.Split(" ");
            CarParkingLot carParkingLot = new CarParkingLot(Int32.Parse(value[1])); ;

            while (input != "exit")
            {
                if (value[0] == "slot_numbers_for_cars_with_colour")
                {
                    carParkingLot.GetSlotsForCarColour(value[1]);
                }
                else if (value[0] == "slot_number_for_registration_number")
                {
                    carParkingLot.GetSlotForCarRegistrationNumber(value[1]);
                }
                else if(value[0] == "registration_numbers_for_cars_with_colour")
                {
                    carParkingLot.GetRegistrationNumberForCarColour(value[1]);
                }
                else if (value[0] == "park")
                {
                    Car car = new Car(value[2],value[1]);
                    carParkingLot.ParkCar(car);
                }
                else if (value[0] == "leave")
                {
                    carParkingLot.Leave(Int32.Parse(value[1]));
                }
                else if (value[0] == "status")
                {
                    carParkingLot.GetStatus();
                }
                input = Console.ReadLine();
                value = input.Split(" ");
            }
        }
    }
}
