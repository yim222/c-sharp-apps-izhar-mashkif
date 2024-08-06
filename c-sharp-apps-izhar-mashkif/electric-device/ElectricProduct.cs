using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.TransportationApp;
using c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module;

namespace c_sharp_apps_izhar_mashkif.electric_device
{
    public class ElectricProduct: IPortable
    {
        private string name;
        protected double watt;
        private int height;
        private int width;
        private int length;
        public double weight;
        public static int serialNum;
        private bool packaged; 

        public ElectricProduct() { }
        public ElectricProduct(string name, double watt, int height, int width, double weight)
        {
            this.name = name;
            this.watt = watt;
            this.height = height;
            this.width = width;
            this.weight = weight;
        }
        public void SetWatt(int watt)
        {
            if(watt>150)
            {
                return;
            }
            this.watt=watt;
        }
        public void DisplayD()
        {
            Console.WriteLine($"name is {name}, watt is {watt}, height is {height}, width is {width},weight is {weight}  ");
        }

        public double GetArea()
        {
            return width * height;
        }


        //w,h,l
        public double[] GetSize()
        {
            //double[] doubles= {}
            return new double[] { width, height, length };
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }

        public double GetWeight()
        {
            throw new NotImplementedException();
        }

        public void PackageItem()
        {
            packaged = true;
        }

        public bool IsPackaged()
        {
            throw new NotImplementedException();
        }

        public void UnPackage()
        {
            throw new NotImplementedException();
        }

        public bool IsFragile()
        {
            throw new NotImplementedException();
        }

        public StorageStructure GetLocation()
        {
            throw new NotImplementedException();
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }
    }
}
