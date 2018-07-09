using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GonzaloCendon
{
    public class Profile
    {        
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string CurrentRole { get; set; }
        public string Country { get; set; }
        public string Industry { get; set; }
        public int NumberOfRecommendations { get; set; }
        public int NumberOfConnections { get; set; }

        public Profile() { }                 
               
    }
}
