using Exercise1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise1.Pages.UserInfo
{
    public partial class Directory
    {
        public List<PersonModel> People { get; set; }

        public Directory()
        {
            People = new List<PersonModel>()
            {
                new PersonModel
                {
                    FirstName = "Steven",
                    LastName = "Pedersen",
                    Addresses = new List<AddressModel>()
                    {
                        new AddressModel
                        {
                            AddressType = "Home Address",
                            RoadName = "Åvænget",
                            HouseNumber = "1a",
                            City = "Taastrup",
                            ZipCode = 2630
                        },
                        new AddressModel
                        {
                            AddressType = "Work Address",
                            RoadName = "Jepsens Vej",
                            HouseNumber = "10",
                            City = "Amager",
                            ZipCode = 2001
                        }
                    }
                },
                new PersonModel
                {
                    FirstName = "Mike",
                    LastName = "Brandt",
                    Addresses = new List<AddressModel>()
                    {
                        new AddressModel
                        {
                            AddressType = "Home Address",
                            RoadName = "Åvænget",
                            HouseNumber = "5",
                            City = "Taastrup",
                            ZipCode = 2630
                        },
                    }
                },
                new PersonModel
                {
                    FirstName = "Kevin",
                    LastName = "Brandt",
                    Addresses = new List<AddressModel>()
                }
            };
        }
    }
}
