using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module
{
    public interface IContainable
    {

        public bool Load(IPortable item);//

        public bool Unload(IPortable item);//
    }
}
