using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp___CLASSES___Student__Hobby__Sport
{
    class Hobby
    {
        public static int numOfHobbies = 0;
        public static List<string> hobbyList = new List<string>();

        public string Name { get; set; }

        public Hobby(string name)
        {
            if (Contains(name)) { return; };
            numOfHobbies += 1;
            Name = name;
            hobbyList.Add(name);
        }

        public static bool Contains(string name)
        {
            if (hobbyList.Contains(name))
            {
                return true;
            }
            return false;
        }
    }
}
