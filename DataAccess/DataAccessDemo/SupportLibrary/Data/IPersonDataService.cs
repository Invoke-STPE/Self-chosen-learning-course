using SupportLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SupportLibrary.Data
{
    public interface IPersonDataService
    {
        Task CreatePerson(IPersonModel person);
        Task DeletePerson(int id);
        Task<List<IPersonModel>> ReadPeople();
        Task<IPersonModel> ReadPeople(int id);
        Task UpdatePerson(IPersonModel person);
    }
}