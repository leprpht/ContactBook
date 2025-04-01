using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactBookConsole.Random_Info_Generator
{
    public static class RandomName
    {
        private static string RandomFirstName()
        {
            string[] firstNames = { "John", "Emily", "Michael", "Sophia", "James", "Olivia", "David", "Isabella", "Daniel", "Ava", "Matthew", "Mia", "Andrew", "Charlotte", "Joseph", "Amelia", "Ethan", "Lily", "William", "Grace", "Alexander", "Chloe", "Benjamin", "Hannah", "Henry", "Ella", "Samuel", "Zoe", "Lucas", "Samantha", "Sebastian", "Layla", "Isaac", "Victoria", "Caleb", "Harper", "Nathan", "Madeline", "Gabriel", "Nora", "Jack", "Aria", "Ryan", "Avery", "Owen", "Addison", "Elijah", "Leah", "Noah", "Lucy", "Daniela", "Leo" };
            Random random = new Random();
            return firstNames[random.Next(0, firstNames.Length)];
        }
        private static string RandomLastName()
        {
            string[] lastNameNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Davis", "Miller", "Wilson", "Moore", "Taylor", "Anderson", "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson", "Garcia", "Martinez", "Roberts", "Clark", "Rodriguez", "Lewis", "Lee", "Walker", "Hall", "Allen", "Young", "King", "Scott", "Green", "Adams", "Baker", "Gonzalez", "Nelson", "Carter", "Mitchell", "Perez", "Evans", "Wright", "Cook", "Morgan", "Cooper", "Diaz", "Reed", "Bailey", "Ramos", "Campbell", "Hughes", "Gomez", "King" };
            Random random = new Random();
            return lastNameNames[random.Next(0, lastNameNames.Length)];
        }
        private static string RandomDomain()
        {
            Random random = new Random();
            string[] domains = { "@gmail.com", "@yahoo.com", "@hotmail.com", "@outlook.com", "@aol.com", "@icloud.com", "@protonmail.com", "@zoho.com" };
            return domains[random.Next(0, domains.Length)];
        }
        public static string[] RandomFullNameAndEmail()
        {
            string[] fullNameAndEmail = new string[2];
            fullNameAndEmail[0] = RandomFirstName() + " " + RandomLastName();
            fullNameAndEmail[1] = fullNameAndEmail[0].Replace(" ", ".").ToLower() + RandomDomain();
            return fullNameAndEmail;
        }
    }
}
