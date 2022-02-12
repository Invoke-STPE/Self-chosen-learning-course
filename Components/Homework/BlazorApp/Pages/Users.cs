using BlazorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Pages
{
    public partial class Users
    {
        List<PersonModel> people;
        public Users()
        {
            people = new List<PersonModel>()
           {
               new PersonModel(1, "Steven", "Pedersen"),
               new PersonModel(2, "Mike", "Brandt"),
               new PersonModel(3, "Kevin", "Brandt"),
           };
        }

        private void updateName(int id, string name)
        {
            PersonModel person = people.SingleOrDefault(p => p.Id == id);
            person.Fullname = name;

        }
    }
}
