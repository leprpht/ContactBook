using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookConsole.Random_Info_Generator
{
    public static class RandomPhone
    {
        public static string RandomPhoneNumber()
        {
            Random random = new Random();
            return random.Next(100, 999).ToString() + "-" + random.Next(1000, 9999).ToString();
        }
    }
}
