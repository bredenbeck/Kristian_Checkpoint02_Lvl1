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
        public int Name { get; set; }
        public List<Player> Players { get; set; }
        #endregion
    }
}
