using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Sports_Management
{
    public class Team
    {
        #region Fields and properties
        public string Name { get; }
        public List<Player> Players { get; set; }
        #endregion

        #region Constructors
        public Team(string name)
        {
            Name = name;
            Players = new List<Player>();
        }
        #endregion

        #region Methods
        public void AddPlayer(string name, int number)
        {
            Players.Add(new Player(name, number));
        }

        public void AddStar(string name, int number, string description)
        {
            Players.Add(new Star(name, number, description));
        }

        public string PrintTeam()
        {
            string team = Name + "\n------------------";

            foreach (Player player in Players)
            {
                team += $"\n{player}";
            }

            Console.WriteLine(team);
            return team;
        }
        #endregion

        #region Methods: Override object class methods
        public override string ToString()
        {
            return Name;
        }

        public bool Equals(Team other)
        {
            return (this.PrintTeam() == other.PrintTeam());
        }

        public override bool Equals(object? obj)
        {
            if (obj is Team other)
            {
                return Equals(other);
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
