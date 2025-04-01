using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookConsole.Random_Info_Generator
{
    public static class RandomAddress
    {
        private static string RandomStreet()
        {
            string[] streetNames = { "Main", "First", "Second", "Third", "Fourth", "Park", "Fifth", "Maple", "Elm", "Oak", "Pine", "Cedar", "Sunset", "Lake", "Hill", "Washington", "Lincoln", "Jackson", "Jefferson", "Madison", "Monroe", "Adams", "Franklin", "Wilson", "Grant", "Sherman", "Lee", "Roosevelt", "Truman", "Kennedy", "Reagan", "Clinton" };
            Random random = new Random();
            return streetNames[random.Next(0, streetNames.Length)];
        }
        private static string RandomCity()
        {
            string[] cityNames = { "Springfield", "Riverside", "Greenville", "Fairview", "Clinton", "Maplewood", "Oakdale", "Lakewood", "Franklin", "Harrison", "Cedarville", "Milltown", "Westfield", "Brooklyn", "Pleasantville", "Woodland", "Silverton", "Newport", "Rockford", "Madison", "Lakeside", "Bayview", "Pinehurst", "Brighton", "Southfield", "Northfield", "Clearwater", "Greenwood", "Woodbury", "Cherryville", "Hillside", "Montgomery", "Bristol", "Lancaster", "Benton", "Shady Grove", "Easton", "Weston", "Kingston", "Cameron", "Unionville", "Arlington", "Westport", "New Haven", "Oakwood", "Carver", "Golden Valley", "Pineville", "Wilmington", "Brookfield" };
            Random random = new Random();
            return cityNames[random.Next(0, cityNames.Length)];
        }
        private static string RandomState()
        {
            string[] stateNames = { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL", "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM", "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            Random random = new Random();
            return stateNames[random.Next(0, stateNames.Length)];
        }
        public static string RandomFullAddress()
        {
            return RandomStreet() + " St " + RandomCity() + " " + RandomState();
        }
    }
}
