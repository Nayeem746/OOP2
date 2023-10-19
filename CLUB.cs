using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPORTS_CLUB
{
    public class player
    {
        private int id;
        private string name;
        private double salary;
        private DateTime joinngDate;

        public player()
        {

        }
        public player(int id, string name, double salary,DateTime joinngDate)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.joinngDate = joinngDate;
        }
        public void ShowPlayerInfo()
        {
            Console.WriteLine("Player Name       :" + name);
            Console.WriteLine("Player Id         :" + id);
            Console.WriteLine("Player Salary     :" + salary);
            Console.WriteLine("Joining Date      :" + joinngDate);
;        }

    }

    public class cricketP:player
    {
        private int totalRun;
        private int totalWiket;

        public cricketP() 
        { 
        
        }
        public cricketP( int id, string name, double salary, DateTime joinngDate, int totalRun, int totalWicket) :base(id, name, salary, joinngDate)
        { 
            this.totalRun = totalRun;
            this.totalWiket = totalWicket;
        }
        public void ShowCricketerInfo()
        {
            ShowPlayerInfo();
            Console.WriteLine("Total Run         :" + totalRun);
            Console.WriteLine("Total Wicket      :" + totalWiket);
        }

    }
    public class footballP:player
    {
        private int totalGoal;
        private int totalAssist;

        public footballP() 
        { 
        
        }

        public footballP(int totalGoal, int totalAssist, int id, string name, double salary, DateTime joinngDate) : base(id, name, salary, joinngDate)
        { 
            this.totalGoal = totalGoal; 
            this.totalAssist = totalAssist; 
        } 
        public void ShowFootballerInfo()
        {
            ShowPlayerInfo();
            Console.WriteLine("Total Goal        :" + totalGoal);
            Console.WriteLine("Total Assist      :" + totalAssist);
        
        }

    }



    internal class CLUB
    {
        static void Main(string[] args)
        {
            cricketP cricketP = new cricketP(75, "Nayeem", 200000.0, new DateTime(2018, 10, 10), 12070, 150);
            cricketP.ShowCricketerInfo();

            Console.WriteLine();

            footballP footballP = new footballP(700, 250, 10, "Rafi", 600000, new DateTime(2020,10,7));
           footballP.ShowFootballerInfo();

        }
    }
}
