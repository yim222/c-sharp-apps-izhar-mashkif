using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public class PublicVehicle
    {

        //empty constructor
        public PublicVehicle()
        {
            this.maxSpeed = 40;
        }



        public PublicVehicle(int line, int id, int maxSpeed, int seats)
        {
            this.line = line;
            this.id = id;
            MaxSpeed = maxSpeed;
            this.seats = seats;
        }

        public PublicVehicle(int line, int id)
        {
            this.line = line;
            this.id = id;
        }

        private int line = 0;
        private int id = 0;
        protected int maxSpeed = 0;
        private int currentPassengers = 0;
        private int seats = 0;
        private bool hasRoom = true;
        private int rejecetedPassengers = 0;

        public int Line { get => line; set => line = value; }
        public int Id { get => id; set => id = value; }
        public virtual int MaxSpeed
        {
            get => maxSpeed; set{

                if (value <= 40)
                {
                    maxSpeed = value;
                }
            }

        }

        public int CurrentPassengers { get => currentPassengers; set => currentPassengers = value; }
        public bool HasRoom { get => hasRoom; set => hasRoom = value; }
        public int Seats { get => seats; set => seats = value; }
        public int RejecetedPassengers { get => rejecetedPassengers; set => rejecetedPassengers = value; }

        public virtual void UploadPassengers(int amt)
        {
            //use has room
            if (!hasRoom) { Console.WriteLine("Full"); return; }
            if(currentPassengers + amt <= seats)
            {
                currentPassengers += amt;
            }
            else
            {
                int gap = seats - currentPassengers;
                rejecetedPassengers = amt - gap;
                currentPassengers += gap;

            }
            hasRoom = CalculateHasRoom();

        }

        public virtual bool CalculateHasRoom()
        {
            return currentPassengers < seats;
        }

        public override string ToString()
        {
            return $"PublicVehicle:[line = {line}, id = {id}, maxSpeed = {maxSpeed}, currentPassenger = {currentPassengers}";
        }
    }
}
