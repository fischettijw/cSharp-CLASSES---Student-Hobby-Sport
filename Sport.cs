using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cSharp___CLASSES___Student__Hobby__Sport
{
    class Sport
    {
        public static int numOfSports = 0;
        public static List<string> sportsList = new List<string>();
        public string Name { get; set; }
        public bool Outdoor { get; set; }
        public char Sex { get; set; }

        public Sport(string name, bool outdoor, char sex)
        {
            if (Contains(name)) { return; };
            numOfSports += 1;
            Name = name;
            sportsList.Add(name);
            Outdoor = outdoor;
            switch (sex)
            {
                case 'M':
                case 'm':
                    Sex = 'M';
                    break;
                case 'F':
                case 'f':
                    Sex = 'F';
                    break;
                default:
                    Sex = 'B';
                    break;
            }
        }
        public static bool Contains(string name)
        {
            if (sportsList.Contains(name))
            {
                return true;
            }
            return false;
        }
    }
}
