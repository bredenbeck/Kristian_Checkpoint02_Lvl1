using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
