using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public class PassengersAirplain : PublicVehicle
    {
        private int enginesNum;
        private int wingLength;
        private int rows; 
        private int columns;

        public PassengersAirplain()
        {
        }

        public PassengersAirplain(int line, int id,
            int enginesNum, int wingLength, int rows, int columns) : base(line, id)
        {

            this.enginesNum = enginesNum;
            this.wingLength = wingLength;
            this.rows = rows;
            this.columns = columns;
            Seats = rows * columns;
        }

        public int EnginesNum { get => enginesNum; set => enginesNum = value; }
        public int WingLength { get => wingLength; set => wingLength = value; }

        public override int MaxSpeed
        {
            get => maxSpeed; set
            {

                if(value <= 1000)
                {
                    maxSpeed = value;
                }
            }
        }

        public int Rows { get => rows; set => rows = value; }
        public int Columns { get => columns; set => columns = value; }

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
            int possibleSeats = Seats - 5;
           
            return possibleSeats;
        }
    }
}
