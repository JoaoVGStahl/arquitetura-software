namespace OOP
{
    // ! Abstração => Oferecer um conjunto de estados e comportamentos que abstraem uma certa especialização
    // ! Quando pensamos em abstração, pensamos no conceito de superclass, ou seja, uma classe que será a base para outras classes
    // ! porem sem impor um comportamento especifico pois cada classes que herdar elas vão por conta propria fazer esta especialização
    public abstract class Eletrodomestico
    {
        private readonly string _nome;
        private readonly int _voltagem;
        protected Eletrodomestico(string nome, int voltagem)
        {
            _nome = nome;
            _voltagem = voltagem;
        }
        // ? um método abstrato não é obrigatório implementar o comportamento dele, a classe especializada que irá definir o comportamento dele
        public abstract void Ligar();
        public abstract void Desligar();
        // ! virtual permite que o metodo seja sobrescrito e alterado seu comportamento
        public virtual void Testar()
        {
            // teste do equipamento
        }
    }
}