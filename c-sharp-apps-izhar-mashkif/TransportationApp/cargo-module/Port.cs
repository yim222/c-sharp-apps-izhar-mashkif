using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.TransportationApp.cargo_module
{
    public class Port : StorageStructure
    {
        public Port() {

            Console.WriteLine("Starting port");
            Items = new List<IPortable>(); 
        }
        public override bool Load(IPortable item)
        {
            Items.Add(item);
            //Console.WriteLine("items count" + Items.Count);

            return Items.Contains(item);
        }

        public override bool Unload(IPortable item)
        {
            Items.Remove(item);
            return !Items.Contains(item);

        }
    }
}
