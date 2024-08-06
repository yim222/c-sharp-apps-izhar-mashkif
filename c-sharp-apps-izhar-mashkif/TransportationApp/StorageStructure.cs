using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module;

namespace c_sharp_apps_izhar_mashkif.TransportationApp
{
    public abstract class StorageStructure : IContainable
    {

        //TODO location details, or address object. 
        private string country = "";

        private List<IPortable> items;

        public List<IPortable> Items { get => items; set => items = value; }

        public abstract bool Load(IPortable item);


        public abstract bool Unload(IPortable item);
        
    }
}
