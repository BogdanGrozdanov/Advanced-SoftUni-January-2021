using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    class Family
    {
        public Family()
        { this.Members = new List<Person>(); }


        public List<Person> Members { get; set; }

        public void AddMember(Person person)
        {
            this.Members.Add(person);
        }

        public Person GetGetOldestMember()
        {
            Person person = this.Members.OrderByDescending(p => p.Age).FirstOrDefault();
            return person;

        }
    }
}
