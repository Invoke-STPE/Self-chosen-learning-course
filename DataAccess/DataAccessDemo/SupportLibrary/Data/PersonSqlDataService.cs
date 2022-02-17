using SupportLibrary.DataAccess;
using SupportLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public class PersonSqlDataService : IPersonDataService
    {
        private readonly ISqlDataAccess dataAccess;

        public PersonSqlDataService(ISqlDataAccess dataAccess)
        {
            this.dataAccess = dataAccess;
        }
        public async Task CreatePerson(IPersonModel person)
        {
            var p = new
            {
                person.FirstName,
                person.LastName,
                person.DateOfBirth
            };
            await dataAccess.SaveData("dbo.spPeople_Create", p, "SQLDB");
        }

        public async Task<List<IPersonModel>> ReadPeople()
        {
            var people = await dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_Read", new { }, "SQLDB");

            return people.ToList<IPersonModel>();
        }
        public async Task<IPersonModel> ReadPeople(int id)
        {
            var people = await dataAccess.LoadData<PersonModel, dynamic>("dbo.spPeople_ReadOne", new { Id = id }, "SQLDB");

            return people.FirstOrDefault();
        }

        public async Task UpdatePerson(IPersonModel person)
        {
            await dataAccess.SaveData("dbo.spPeople_Update", person, "SQLDB");
        }
        public async Task DeletePerson(int id)
        {
            await dataAccess.SaveData("dbo.sp_People_Delete", new { Id = id }, "SQLDB");
        }
    }
}
