using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.TransportationApp;
using c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module;

namespace c_sharp_apps_izhar_mashkif.products
{
    internal class GeneralProduct : IPortable
    {

        public override string ToString()
        {
            return "General product... TODO ";
        }
        //todo ... insert some variables 
        public double GetArea()
        {
            throw new NotImplementedException();
        }

        public StorageStructure GetLocation()
        {
            throw new NotImplementedException();
        }

        public double[] GetSize()
        {
            throw new NotImplementedException();
        }

        public double GetVolume()
        {
            throw new NotImplementedException();
        }

        public double GetWeight()
        {
            throw new NotImplementedException();
        }

        public bool IsFragile()
        {
            throw new NotImplementedException();
        }

        public bool IsLoaded()
        {
            throw new NotImplementedException();
        }

        public bool IsPackaged()
        {
            throw new NotImplementedException();
        }

        public void PackageItem()
        {
            throw new NotImplementedException();
        }

        public void UnPackage()
        {
            throw new NotImplementedException();
        }
    }
}
