using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet8
{
    public class Player
    {

        //this is what is inside the tables
        public int PlayerID { get; set; }

        public string Name { get; set; }

        public string Position { get; set; }


        public int TeamID { get; set; }
        public virtual Team Team { get; set; }


    }

    public class Team
    {

        //this is what is inside the table 
        public int TeamID { get; set; }

        public string TeamName { get; set; }

        public string Location { get; set; }

        public virtual List<Player> Players { get; set; }
    }


    public class TeamData : DbContext
    {
        //overiding the dbcontext constructor //passing in a name for the context
        public TeamData() : base("MyTeamData") { }

        //player table
        public DbSet<Player> Players { get; set; }

        //team table
        public DbSet<Team> Teams { get; set; }



    }
}
