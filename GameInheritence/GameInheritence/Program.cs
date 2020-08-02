using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInheritence
{
    class Game
    {
        public int noOfPlayers;
        public string country;

        public int NoOfPlayers
        {
            get { return noOfPlayers; }
            set { noOfPlayers = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public Game()
        {

        }
        public Game(int _noOfPlayer, string _country)
        {
            noOfPlayers = _noOfPlayer;
            country = _country;

        }

        public void WorldCup(string country, string game)
        {

            Console.WriteLine("{0} have won the {1} World Cup {2} ", country, game, DateTime.Now.ToString("yyyy"));
        }

    }

    class Cricket : Game
    {
        public string coachName;
        public string CoachName
        {
            get { return coachName; }
            set { coachName = value; }
        }
        public Cricket()
        {

        }
        public Cricket(int _players, string _country, string _coachName) : base(_players, _country)
        {
            coachName = _coachName;

        }



        class Football : Game
        {
            public string leagueName;
            public string LeagueName
            {
                get { return leagueName; }
                set { leagueName = value; }
            }
            public Football()
            {

            }
            public Football(int _players, string _country, string _leagueName) : base(_players, _country)
            {
                leagueName = _leagueName;
            }

        }

        class ShowGameDetails
        {
            public void ShowCricketDetails(int noOfPlayers, string country, string coachName)
            {

                Console.WriteLine("Country: {0} No of Players: {1} Coach Name: {2}", country, noOfPlayers, coachName);
            }

            public void ShowFootballDetails(int noOfPlayers, string country, string leagueName)
            {

                Console.WriteLine("Country: {0} No of Players: {1} League Name: {2}", country, noOfPlayers, leagueName);

            }
        }
        class Program
        {
            static void Main(string[] args)
            {
                Cricket India = new Cricket();
                Cricket Australia = new Cricket();

                Football Spain = new Football();
                Football England = new Football();

                ShowGameDetails show = new ShowGameDetails();
                Console.WriteLine("------------Cricket Information----------");
                show.ShowCricketDetails(11, "India", "John Wright");
                show.ShowCricketDetails(11, "Australia", "John Buchanan");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("------------FootBall Information----------");
                show.ShowFootballDetails(14, "Spain", "Spanish League");
                show.ShowFootballDetails(13, "England", "English Premiur League");
                Console.WriteLine();
                Console.WriteLine();
                Game obj = new Game();
                obj.WorldCup("India", "Cricket");
                obj.WorldCup("Spain", "Football");

                Console.Read();

            }
        }
    }
}




