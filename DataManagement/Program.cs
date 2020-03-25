using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LabSheet8; //reference to use team data


namespace DataManagement
{
    class Program
    {
        static void Main(string[] args)
        {

            //create new teamdata 
            TeamData db = new TeamData(); 

            //writing to files it means if anything goes wrong will safely close
            //all props
            using(db)
            {
                Team t1 = new Team() { TeamID = 1, TeamName = "Sligo Rovers", Location = "Sligo" };
                Player p1 = new Player() { PlayerID = 1, Name = "Tom", Position = "Forward", TeamID = 1, Team = t1 };
                Player p2 = new Player() { PlayerID = 2, Name = "Nick", Position = "Defender", TeamID = 1, Team = t1 };

                Team t2 = new Team() { TeamID = 2, TeamName = "Finn Harpes", Location = "Donega;" };
                Player p3 = new Player() { PlayerID = 3, Name = "Same", Position = "Midfielder", TeamID = 2, Team = t2};
                Player p4 = new Player() { PlayerID = 4, Name = "Jim", Position = "Goalkeeper", TeamID = 2, Team = t2 };


                db.Teams.Add(t1);

                db.Teams.Add(t2);

                Console.WriteLine("Added Teams to database");

                db.Players.Add(p1);
                db.Players.Add(p2);
                db.Players.Add(p3);
                db.Players.Add(p4);

                Console.WriteLine("Added players to database");
                db.SaveChanges();

                Console.WriteLine("Saved to database");

            }


        }
    }
}
