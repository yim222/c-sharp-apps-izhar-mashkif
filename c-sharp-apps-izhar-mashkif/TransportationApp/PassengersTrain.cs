using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public class PassengersTrain : PublicVehicle
    {
        private Crone[] crones = null;
        private int cronesAmount = 0;
        public PassengersTrain(int line, int id, int maxSpeed, Crone crone, int cronesAmount ) : base(line, id, maxSpeed, 0)
        {
            this.crones = new Crone[cronesAmount];
            //calculate seats

            for ( int i = 0; i < cronesAmount; i++)
            {
                crones[i] = new Crone(crone);
                Seats += crones[i].GetSeats();

            }



        }
        public override int MaxSpeed
        {
            get => maxSpeed;
            set
            {
                if (value <= 300)
                {
                   maxSpeed = value;
                }

            }
        }

        public Crone[] Crones { get => crones; set => crones = value; }
        public int CronesAmount { get => cronesAmount; set => cronesAmount = value; }

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
            int possibleSeats = Seats;
            for (int i = 0; i < crones.Length; i++)
            {
                possibleSeats += crones[i].GetExtras();
            }
            return possibleSeats;
        }
    }
}
