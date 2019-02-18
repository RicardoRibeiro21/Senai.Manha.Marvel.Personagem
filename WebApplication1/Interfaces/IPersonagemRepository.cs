using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Domains;

namespace WebApplication1.Interfaces
{
    interface IPersonagemRepository
    {
        List<PersonagemDomain> Listar();
        void Gravar(PersonagemDomain personagem, int Id);
    }
}
