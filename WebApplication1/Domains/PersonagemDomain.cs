using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Domains
{// Hey hacker, para de ser malvado ;(
    public class PersonagemDomain
    {
        public int Id { get; set; }
        [Required] [StringLength(1 ,MinimumLength = 3)]
        public string Nome { get; set; }
        public string Lancamento { get; set; }
    }
}
