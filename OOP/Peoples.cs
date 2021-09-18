using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Peoples
    {
        private readonly List<People> PeopleList;

        public Peoples()
        {
            PeopleList = new List<People>();
        }

        public void AddPeople(People people)
        {
            PeopleList.Add(people);
        }

        public People this[string name]
        {
            get
            {
                var people = PeopleList.Where(x => x.Name == name).FirstOrDefault();
                return people;
            }
        }

        public int TotalPeoplesCount()
        {
            return PeopleList.Count;
        }
     
        public  List<People> TotalPeople()
        {
            return PeopleList;
        }
    }
}
