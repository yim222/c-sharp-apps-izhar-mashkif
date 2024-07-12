using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_apps_izhar_mashkif.MyDataApp;

namespace c_sharp_apps_izhar_mashkif.SportApp
{
    public class GeneralPlayer : InterfaceData
    {

        private int points = 0;
        private string name = "";
        private string scoreName = "";//שם ההבקעה
        private int assists = 0;
        private int fouls = 0;
        private bool outOfGame = false;

        public int GetPoints() { return points; }
        public void SetPoints(int points) { this.points = points; }

        //public int Points { get => points; set => points = value; }
        public string Name { get { return name; } set { name = value; }  }

        public GeneralPlayer(string name, string scoreName)
        {
            this.name = name;
            this.scoreName = scoreName;
           
        }

        public string GenerateData()
        {
            return "player is " + name;
        }

        public void Do1() { Console.WriteLine("Do nothing general player"); }
        public string ScoreName { get => scoreName; set => scoreName = value; }
        public int Assists { get => assists; set => assists = value; }
        public int Fouls { get => fouls; set => fouls = value; }
        public bool OutOfGame { get => outOfGame; set => outOfGame = value; }
        public int Points { get => points; set => points = value; }

        public override string ToString()
        {
            return $"GeneralPlayer[name = {name} ,points = {points}]";
        }
        public virtual void ScoreField()
        {
            points++;
            DisplayScore();

        }

        public void DisplayScore()
        {
            Console.WriteLine($"{name} scored a {scoreName}!");
        }

        public virtual void AddFoul()
        {
            fouls++;
            Console.WriteLine("Foul");
        }


        /*
* 	Create GeneralPlayer:
o	
o	Methods:
	ScoreField(): void
	DisplayScore(): void – Method that prints that the player scored. For example: "Messy score a goal".
	AddFoul(): void – Method that add one foul to the fouls.
*/
    }
}
