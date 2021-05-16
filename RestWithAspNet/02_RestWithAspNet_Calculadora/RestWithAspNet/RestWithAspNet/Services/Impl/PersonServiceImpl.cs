using RestWithAspNet.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RestWithAspNet.Services.Impl
{
    public class PersonServiceImpl : IPersonService
    {
        private volatile int count;

        public Person Create(Person person)
        {
            return person;
        }

        public void Delete(long id)
        {
            
        }

        public List<Person> findAll()
        {
            List<Person> persons = new List<Person>();
            for (int i = 0; i < 8; i++) {
                Person person = MockPerson(i);
                persons.Add(person);
            }

            return persons;
        }

        

        public Person FindById(long id)
        {
            return new Person
            {
                ID = IncrementAndGet(),
                firstName = "Rodrigo",
                lastName = "Santos",
                address = "Kaloré - Paraná - Brazil",
                Gender = "Male"
            };
        }

        public Person Update(Person person)
        {
            return person;
        }

        private Person MockPerson(int i)
        {
            return new Person
            {
                ID = IncrementAndGet(),
                firstName = "Person name" +i,
                lastName = "Last name" + i,
                address = "Some Address" + i,
                Gender = "Male"
            };
        }

        private long IncrementAndGet()
        {
            return Interlocked.Increment(ref count);
        }
    }
}
