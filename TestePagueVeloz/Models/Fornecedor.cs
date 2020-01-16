using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestePagueVeloz.Models
{
    public class Fornecedor
    {

        public int FornecedorId { get; set; }
        private string _nome { get; set; }
        private string _cnpjOuCPpf { get; set; }
        private string _rg { get; set; }
        private DateTime _dataDeCadastro { get; set; }
        private DateTime _dataDeNascimento { get; set; }
        private string _telefone { get; set; }
        private Empresa _empresa { get; set; }
        private int? _empresaId { get; set; }

        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Nome do fornecedor deve conter um valor");
                }
                _nome = value;
            }
        }
        public string CnpjOuCpf
        {
            get { return _cnpjOuCPpf; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("CPF / CNPJ do fornecedor deve conter um valor");
                }
                _cnpjOuCPpf = value;
            }
        }

        public string Rg
        {
            get { return _rg; }
            set { _rg = value; }
        }

        public DateTime DataDeCadastro
        {
            get { return _dataDeCadastro; }
            set { _dataDeCadastro = value; }
        }

        public DateTime DataDeNascimento
        {
            get { return _dataDeNascimento; }
            set { _dataDeNascimento = value; }
        }

        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Necessário informar o telefone do fornecedor");
                }
                _telefone = value;
            }
        }

        public Empresa Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }

        public int? EmpresaId
        {
            get { return _empresaId; }
            set { _empresaId = value; }
        }


        public Fornecedor()
        {
        }

        public Fornecedor(string nome, string cnpjOuCnpf, DateTime dataDeCadastro, string telefone, Empresa empresa)
        {
            Nome = nome;
            CnpjOuCpf = cnpjOuCnpf;
            DataDeCadastro = dataDeCadastro;
            Telefone = telefone;
            Empresa = empresa;
            if (empresa != null)
            {
                EmpresaId = empresa.EmpresaId;
            }
        }

        public Fornecedor(string nome, string cnpjOuCpf, string rg, DateTime dataDeCadastro, DateTime dataDeNascimento, string telefone, Empresa empresa)
        {
            if (string.IsNullOrEmpty(rg) || dataDeNascimento == DateTime.MinValue)
            {
                throw new ArgumentNullException("Para o cadastro de pessoa fisica, é necessário informar data de nascimento e RG");
            }

            if ( empresa!= null && empresa.Uf == UF.PR)
            {
                var hoje = DateTime.Now;
                if (hoje < DataDeNascimento.AddYears(17))
                {
                    throw new ArgumentOutOfRangeException("Para o estado do Paraná, o fornecedor não pode ter menos de 18 anos");
                }
            }

            Nome = nome;
            CnpjOuCpf = cnpjOuCpf;
            Rg = rg;
            DataDeCadastro = dataDeCadastro;
            DataDeNascimento = dataDeNascimento;
            Telefone = telefone;
            Empresa = empresa;
            if (empresa != null)
            {
                EmpresaId = empresa.EmpresaId;
            }
        }
    }
}
