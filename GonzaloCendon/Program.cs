using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace GonzaloCendon
{
    class Program
    {
        static void Main(string[] args)
        {                        
            List<Profile> profiles = FileReader(@"C:\Users\gcendon.XPLAN\Downloads\people.in");

            profiles = profiles.OrderByDescending(Profile => Profile.NumberOfConnections).ToList();

            //profiles.OrderByDescending(x => x.NumberOfConnections).ThenBy(x => x.NumberOfRecommendations);


            foreach (var s in profiles)
            {
                Console.WriteLine(s.PersonId);
            }

            Console.ReadKey();
                               
        }
        public static List<Profile> FileReader(string path)
        {            
            string line;
            StreamReader file = new StreamReader(path);
            List<Profile> profiles = new List<Profile>();
            while ((line = file.ReadLine()) != null)
            {
                string[] splits = line.Split('|');
                if (splits.Length!=8)
                {
                    throw new Exception ("Invalid number of fields");
                }              
                
                Profile profile = new Profile();
                profile.PersonId = (Convert.ToInt32(splits[0]));
                profile.Name = splits[1];
                profile.LastName = splits[2];
                profile.CurrentRole = splits[3];
                profile.Country = splits[4];
                profile.Industry = splits[5];
                profile.NumberOfRecommendations = (Convert.ToInt32(splits[6]));
                profile.NumberOfConnections = (Convert.ToInt32(splits[7]));
                profiles.Add(profile);
            }
            return profiles;
        }
    }
}

