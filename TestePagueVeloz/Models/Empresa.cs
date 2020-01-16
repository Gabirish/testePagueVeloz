using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestePagueVeloz.Models
{
    public class Empresa
    {

        public int EmpresaId { get; set; }
        private UF _uf { get; set; }
        private string _cnpj { get; set; }
        private string _nomeFantasia { get; set; }

        public UF Uf
        {
            get { return _uf; }
            set { _uf = value; }
        }

        public string Cnpj
        {
            get { return _cnpj; }
            set { _cnpj = value; }
        }

        public string NomeFantasia
        {
            get { return _nomeFantasia; }
            set { _nomeFantasia = value; }
        }

        public Empresa(UF uf, string cnpj, string nomeFantasia)
        {
            if (string.IsNullOrEmpty(cnpj)) { throw new ArgumentNullException("Necessário informar o CNPJ"); }
            if (string.IsNullOrEmpty(nomeFantasia)) { throw new ArgumentNullException("Necessário informar o CNPJ"); }
            Uf = uf;
            Cnpj = cnpj;
            NomeFantasia = nomeFantasia;
        }

        public Empresa()
        {
        }
    }
}
