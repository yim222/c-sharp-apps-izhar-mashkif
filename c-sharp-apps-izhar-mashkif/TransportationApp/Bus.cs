using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public class Bus : PublicVehicle
    {
        private readonly int doors;
        private bool bellStop = false;



        public Bus()
        {

        }
        public Bus(int line, int id, int maxSpeed, int seats, int doors) : base(line, id, maxSpeed, seats)
        {
            this.doors = doors;
        }

        public override int MaxSpeed
        {
            get => maxSpeed; set
            {

                if (value <= 120)
                {
                    maxSpeed = value;
                }
            }
        }

        public override void UploadPassengers(int amt)
        {
            //use has room
            if (!HasRoom) { Console.WriteLine("Full"); return; }
            if (CurrentPassengers + amt <= GetMaxPossilbeSeats())
            {
                CurrentPassengers += amt;
            }
            else
            {
                int gap = GetMaxPossilbeSeats() - CurrentPassengers;
                RejecetedPassengers = amt - gap;
                CurrentPassengers += gap;

            }
            HasRoom = CalculateHasRoom();

        }

        public override bool CalculateHasRoom()
        {
            return CurrentPassengers < GetMaxPossilbeSeats();
        }

        private int GetMaxPossilbeSeats()
        {
            return (int)Math.Round(Seats * 1.10);
        }
    }
}
