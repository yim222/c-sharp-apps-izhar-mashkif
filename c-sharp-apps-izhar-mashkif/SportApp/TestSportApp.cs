using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_apps_izhar_mashkif.SportApp
{
    public class TestSportApp
    {

        public static void Test1()
        {
            Console.WriteLine("Test Sport App");

            GeneralPlayer g1 = new GeneralPlayer("Messy", "Goal");
            g1.ScoreField();
            Console.WriteLine(g1);
            BasketballPlayer b1 = new BasketballPlayer("Jordan", "Basket");
            b1.AddFoul();
            b1.ScoreField();
            b1.ScoreField();
            b1.Score3();

            Console.WriteLine(b1);

            SoccerPlayer s1 = new SoccerPlayer("Ronaldo", "Goal");

            GeneralPlayer g2 = new BasketballPlayer("Kaspi", "Basket");

            GeneralPlayer[] players = { g1, b1, s1, g2 };

            Console.WriteLine("\nStarting loop:\n");
            for(int i =0; i < players.Length; i++)
            {
                GeneralPlayer g = players[i];
                g.AddFoul();
                g.ScoreField();
                Console.WriteLine(g);
                if(g is BasketballPlayer)
                {
                    BasketballPlayer b = (BasketballPlayer)g;
                    Console.WriteLine("Dunks = " + b.Dunks );

                    Console.WriteLine("Dunks = " + ((BasketballPlayer)g).Dunks);

                }
            }

        }
    }
}
