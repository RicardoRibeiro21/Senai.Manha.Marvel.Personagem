using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Domains;
using WebApplication1.Interfaces;
using WebApplication1.Repositories;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PersonagensController : Controller
    {
        List<PersonagemDomain> ListPersonagem = new List<PersonagemDomain>();
        private IPersonagemRepository Repository { get; set; }

        public PersonagensController()
        {
            Repository = new PersonagemRepository();
        }

    }
}