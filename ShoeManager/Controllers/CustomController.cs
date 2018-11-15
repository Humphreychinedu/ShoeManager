using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoeManagerBL.Domain;
using ShoeManagerBL.Service;

namespace ShoeManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomController : ControllerBase
    {
        private readonly IPersonService _personService;

        public CustomController(IPersonService personService)
        {
            this._personService = personService;
        }

        public Task<IEnumerable<Person>> GetPerson(string name)
        {
            return this._personService.GetPersons(name);
        }
    }
}