using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestePagueVeloz.Models;

namespace TestePagueVeloz.ViewModel
{
    public class EmpresaViewModel
    {
        [Display(Name = "CNPJ")]
        public string CNPJ { get; set; }

        [Display(Name = "Nome Fantasia")]
        public string NomeFantasia { get; set; }

        [Display(Name = "Estado")]
        public UF UF { get; set; }
    }
}
