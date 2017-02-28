using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament
{
    public class Spiller
    {
        public enum GenderType { Male, Female};

        private String FirstName { get; set; }
        private String LastName { get; set; }
        private int Age { get; set; }
        private GenderType Gender { get; set; }

        public Spiller(string fn, string ln, int age, GenderType g)
        {
            FirstName = fn;
            LastName = ln;
            Age = age;
            Gender = g;
        }

        public override string ToString()
        {
            var rv = FirstName + " " + LastName + " " + Age + " " + Gender;
            return rv;
        }

        static void Main(string[] args)
        {
            var smissel = new Spiller("Niklas", "Missel", 22, GenderType.Male);
            Console.WriteLine(smissel);
            Console.ReadLine();
        }

    }
}
