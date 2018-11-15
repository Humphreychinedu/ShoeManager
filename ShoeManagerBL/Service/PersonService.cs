using Dapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using ShoeManagerBL.Domain;

namespace ShoeManagerBL.Service
{
    public class PersonService : BaseService, IPersonService
    {
        public PersonService(IConfiguration configuration) : base(configuration)
        {
            
        }

        //An Asyncchronus insert method
        public Task CreatePerson(Person person)
        {
            return Task.Run(() => { 
            using (var conn = this.connection)
            {
                string spName = "InsertPerson";
                conn.Open();
                conn.ExecuteAsync(spName,
                    new { person.FirstName, person.LastName, person.Gender },
                    commandType: System.Data.CommandType.StoredProcedure);
            }
            });
        }

        //public Task<IList<Person>> GetPersons(string name)
        //{
        //     Task.Run(async () => {
        //         using (var conn = this.connection)
        //         {
        //             string spName = "uspGetPerson3";
        //             conn.Open();
        //             return await conn.QueryAsync(spName, new { name }, commandType: System.Data.CommandType.StoredProcedure)
        //             as
        //             IList<Person>;
        //         }
        //     });
        //   return null;
        //}

        public async Task<IEnumerable<Person>>GetPersons(string name)
        {
            IEnumerable<Person> test;
            using(var conn = this.connection)
            {
                string spName = "uspGetPerson3";
                conn.Open();

                test = await conn.QueryAsync<Person>(spName, new { name }, commandType: System.Data.CommandType.StoredProcedure);
            }
            return test;
        }
  
    }
}
