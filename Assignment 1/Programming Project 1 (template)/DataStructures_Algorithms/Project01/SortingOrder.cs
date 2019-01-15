using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms.Project01
{
    public class SortingOrder
    {
        public bool f1 = false, f2 = false, f3 = false, f4 = false, f5 = false, f6 = false;

        public string Solve(string[] name, int[] age, int[] weight)
        {
            
            List<Person> personGiven = new List<Person>();

            for (int i = 0; i < name.Length; i++)
            {
                personGiven.Add(new Person(name[i], age[i], weight[i]));
            }

            var NAW = personGiven.OrderByDescending(x => x.Weight).OrderBy(x => x.Age).OrderBy(x => x.Name).ToList();
            var NWA = personGiven.OrderBy(x => x.Age).OrderByDescending(x => x.Weight).OrderBy(x => x.Name).ToList();
            var ANW = personGiven.OrderByDescending(x => x.Weight).OrderBy(x => x.Name).OrderBy(x => x.Age).ToList();
            var AWN = personGiven.OrderBy(x => x.Name).OrderByDescending(x => x.Weight).OrderBy(x => x.Age).ToList();
            var WAN = personGiven.OrderBy(x => x.Name).OrderBy(x => x.Age).OrderByDescending(x => x.Weight).ToList();
            var WNA = personGiven.OrderBy(x => x.Age).OrderBy(x => x.Name).OrderByDescending(x => x.Weight).ToList();

            for (int i = 0; i < personGiven.Count(); i++)
            {
                

                if (!(personGiven[i].Name.Equals(NAW[i].Name) && personGiven[i].Age.Equals(NAW[i].Age) && personGiven[i].Weight.Equals(NAW[i].Weight))) { f1 = true; }

                if (!(personGiven[i].Name.Equals(NWA[i].Name) && personGiven[i].Age.Equals(NWA[i].Age) && personGiven[i].Weight.Equals(NWA[i].Weight))) { f2 = true; }

                if (!(personGiven[i].Name.Equals(ANW[i].Name) && personGiven[i].Age.Equals(ANW[i].Age) && personGiven[i].Weight.Equals(ANW[i].Weight))) { f3 = true; }

                if (!(personGiven[i].Name.Equals(AWN[i].Name) && personGiven[i].Age.Equals(AWN[i].Age) && personGiven[i].Weight.Equals(AWN[i].Weight))) { f4 = true; }

                if (!(personGiven[i].Name.Equals(WAN[i].Name) && personGiven[i].Age.Equals(WAN[i].Age) && personGiven[i].Weight.Equals(WAN[i].Weight))) { f5 = true; }

                if (!(personGiven[i].Name.Equals(WNA[i].Name) && personGiven[i].Age.Equals(WNA[i].Age) && personGiven[i].Weight.Equals(WNA[i].Weight))) { f6 = true; }

            }

            int count = 0;
            string answer = "NOT";

            if (!f1) { count++; answer = "NAW"; }
            if (!f2) { count++; answer = "NWA"; }
            if (!f3) { count++; answer = "ANW"; }
            if (!f4) { count++; answer = "AWN"; }
            if (!f5) { count++; answer = "WAN"; }
            if (!f6) { count++; answer = "WNA"; }
            if (count > 1) { answer = "IND"; }

            return answer;

        }

        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public int Weight { get; set; }

            public Person(string name, int age, int weight)
            {
                this.Name = name;
                this.Age = age;
                this.Weight = weight;
            }
        }
    }
}

