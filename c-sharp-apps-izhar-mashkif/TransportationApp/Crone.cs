using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public class Crone
    {
        private readonly int rows, columns;

        public Crone(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }


        //copying constructor
        public Crone(Crone crone)
        {
            this.rows = crone.rows;
            this.columns = crone.columns;
        }
        public int Rows { get => rows; }

        public int Columns => columns;

        public int GetSeats()
        {
            return rows * columns;
        }
        public int GetExtras()
        {
            return rows * 2;
        }
    }
}
