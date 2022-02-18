using SupportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public class PersonDummyDataService : IPersonDataService
    {
        private List<IPersonModel> people = new List<IPersonModel>();
        private int currentId = 0;


        public Task CreatePerson(IPersonModel person)
        {
            return Task.Run(() => {
                currentId += 1;
                person.Id = currentId;
                people.Add(person); 
            });
        }

        public Task DeletePerson(int id)
        {
            return Task.Run(() => { people.Remove(people.Where(x => x.Id == id).FirstOrDefault()); });
        }

        public Task<List<IPersonModel>> ReadPeople()
        {
            return Task.FromResult(people);
        }

        public Task<IPersonModel> ReadPeople(int id)
        {
            return Task.FromResult(people.Where(x => x.Id == id).FirstOrDefault() ); 
        }
        public Task<List<IPersonModel>> ReadPeople(string query)
        {
            return Task.FromResult(people.Where(x => x.FirstName.ToLower().Contains(query.ToLower()) || 
                                                     x.LastName.ToLower().Contains(query.ToLower()))
                                                     .ToList());
        }

        public Task UpdatePerson(IPersonModel person)
        {
            return Task.Run(() => {
                var p = people.Where(x => x.Id == person.Id).FirstOrDefault();
                if (p != null)
                {
                    p.FirstName = person.FirstName;
                    p.LastName = person.LastName;
                    p.DateOfBirth = person.DateOfBirth;
                }
            });
        }
    }
}
