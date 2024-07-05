using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.SportApp
{
    public class SoccerPlayer : GeneralPlayer
    {
        private bool redCard = false;
        private int penalties = 0;
        protected int dribblingRate = 0;//1-10
        private readonly string onlyFinal = "kkk";
        private readonly string onlyFinal2;
        private const string onlyConst = "ss";



        public SoccerPlayer(string name, string scoreName) : base(name, scoreName)
        {
            onlyFinal = "aaa";
        }

        public void Do1()
        {
           // onlyFinal2 = "sss";//not working 
        }
        public bool RedCard { get => redCard; set => redCard = value; }
        public int Penalties { get => penalties; set => penalties = value; }
        public virtual int DribblingRate
        {
            get => dribblingRate;
            set
            {
                if(value >=1 && value <=10)
                dribblingRate = value;
            }
        }
    }
}
