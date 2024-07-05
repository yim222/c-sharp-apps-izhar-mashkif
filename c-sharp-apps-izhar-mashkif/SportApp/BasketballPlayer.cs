using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.SportApp
{
    public class BasketballPlayer : GeneralPlayer
    {
        private int dunks = 0;
    	private int threeShots = 0;
	    private int rebounds = 0;

        public BasketballPlayer(string name, string scoreName) : base(name, "Basket")
        {
        }

        public BasketballPlayer(string name, string scoreName, 
            int dunks, int threeShots, int rebounds): base(name, scoreName) 
        {
            this.dunks = dunks;
            this.threeShots = threeShots;
            this.rebounds = rebounds;
        }

        public int Dunks { get => dunks; set => dunks = value; }
        public int ThreeShots { get => threeShots; set => threeShots = value; }
        public int Rebounds { get => rebounds; set => rebounds = value; }

        public override void AddFoul()
        {
            base.AddFoul();
            if (Fouls == 5)
            {
                OutOfGame = true;
                Console.WriteLine(Name + " is Out Of Game ");
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"BasketballPlayer: [threeShots = {threeShots}]";
        }

        public override void ScoreField()
        {
            Points += 2;
            DisplayScore();
        }
        public  void Score3()
        {
            Points += 3;
            threeShots++;
            //DisplayScore();
        }

    }
}
