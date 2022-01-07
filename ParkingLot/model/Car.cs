using System;
namespace ParkingLot.model
{
    public class Car: IVehicle
    {
        private string RegNo, Colour;

        public Car(string Colour,string RegNo)
        {
            this.Colour = Colour;
            this.RegNo = RegNo;
        }

        public string getCarNo()
        {
            return RegNo;
        }

        public string getCarColour()
        {
            return Colour;
        }
    }
}
