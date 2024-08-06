using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module
{
    public interface IPortable
    {


        public double GetArea();//שטח
        public double[] GetSize();//w,h,l
        public double GetVolume();//נפח
        public double GetWeight();

        public void PackageItem();
        public bool IsPackaged();

        public void UnPackage();

        public bool IsFragile();

        public StorageStructure GetLocation();
        public bool IsLoaded();

    }
}
