using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.electric_device
{
    public class PC: ElectricProduct
    {
        private string model;
        public PC(string model)
        {
            this.model = model;
        }

        public override string ToString()
        {
            return $"model is {model}";
        }
        public  string GetModel()
        {
            return model;
        }
    }
}
