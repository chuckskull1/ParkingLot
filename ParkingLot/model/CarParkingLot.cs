using System;
using System.Collections.Generic;

namespace ParkingLot.model
{
    public class CarParkingLot
    {
        private int capacity;
        private Car[] lot;

        public CarParkingLot(int capacity)
        {
            this.capacity = capacity;
            this.lot = new Car[capacity];
            Console.WriteLine("Created");
        }

        public void GetStatus()
        {
            Console.WriteLine("Slot No.\tRegistration No Colour");
            for (int i = 0; i < capacity; i++)
            {
                if (lot[i] != null)
                {
                    Console.WriteLine($"{i + 1} \t {lot[i].getCarNo()}{lot[i].getCarColour()}");
                }
            }
        }

        public void Leave(int slot)
        {
            if (slot > 0 && slot <= this.capacity)
            {
                lot[slot - 1] = null;
                Console.WriteLine("Slot number {0} is free", slot);
            }
            else
            {
                Console.WriteLine("Slot doesn't exist");
            }
        }

        public void ParkCar(Car car)
        {
            for( int i=0; i<capacity; i++)
            {
                if(lot[i] == null)
                {
                    lot[i] = car;
                    Console.WriteLine($"Allocated slot number: {i+1}");
                    return;
                }
            }
            Console.WriteLine("Sorry, parking lot is full");
        }

        public void GetSlotsForCarColour(string colour)
        {
            string slots="";
            for(int i = 0; i< capacity; i++)
            {
                if (lot[i] != null)
                    if (colour == lot[i].getCarColour())
                    {
                        int slot = i + 1;
                        slots += "," + slot;
                    }
            }
            if (slots == "")
                Console.WriteLine($"No Car with {colour} colour is parked");
            else
                Console.WriteLine(slots);
        }

        public void GetSlotForCarRegistrationNumber(string RegNo)
        {
            for (int i = 0; i < capacity; i++)
            {
                if (lot[i] != null)
                    if (RegNo == lot[i].getCarNo())
                    {
                        Console.WriteLine(i+1);
                        return;
                    }
            }
            Console.WriteLine("Not found");
        }

        public void GetRegistrationNumberForCarColour(string colour)
        {
            string slots = "";
            for (int i = 0; i < capacity; i++)
            {
                if (lot[i] != null)
                    if (colour == lot[i].getCarColour())
                    {
                        slots += "," + lot[i].getCarNo();
                    }
            }
            if (slots == "")
                Console.WriteLine($"No Car with {colour} colour is parked");
            else
                Console.WriteLine(slots);
        }
    }
}
