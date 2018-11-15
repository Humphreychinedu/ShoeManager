using ShoeManagerBL.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShoeManagerBL.Service
{
    public interface IPersonService
    {
        Task<IEnumerable<Person>> GetPersons(string name);

        Task CreatePerson(Person person);
    }
}
