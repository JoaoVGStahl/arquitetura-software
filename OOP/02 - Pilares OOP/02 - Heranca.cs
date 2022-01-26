using System;

namespace OOP
{   
    // ? Funcionário é uma pessoa, neste caso estamos estendendo a 
    // ? classe pessoa com a especialização em Funcionário
    // * Funcionário é uma pessoa
    public class Funcionario : Pessoa
    {
        public DateTime DataAdmissao { get; set; }
        public string Registro { get; set; }
    }

    public class Processo
    {
        public void Execucao()
        {
            // ! Comportamentos e estados herdados da classe Pessoa
            var funcionario = new Funcionario()
            {
                Nome = "João da Silva",
                DataNascimento = Convert.ToDateTime("1990/01/01"),
                DataAdmissao = DateTime.Now,
                Registro = "0123456",
            };

            funcionario.CalcularIdade();
        }
    }
}