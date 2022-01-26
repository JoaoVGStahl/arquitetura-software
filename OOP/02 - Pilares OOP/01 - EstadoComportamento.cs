using System;

namespace OOP
{
    // ! Fazem referência a uma classe
    public class Pessoa
    {
        // ? Estado é respresentado através das propriedades
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        // ? Comportamento são métodos que processam a informações, geram uma nova ou alteram o estado da entidade, 
        // ? ou seja modificam o valor presente nas propriedades da classe
        public int CalcularIdade()
        {
            var dataAtual = DateTime.Now;
            var idade = dataAtual.Year - DataNascimento.Year;

            if (dataAtual < DataNascimento.AddYears(idade)) idade--;

            return idade;
        }
    }
}