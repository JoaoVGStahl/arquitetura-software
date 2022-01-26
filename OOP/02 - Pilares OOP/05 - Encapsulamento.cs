
namespace OOP
{
    // ? A Arte de encapsular comportamentos através da exposição de métodos publicos e tambem a escrita de métodos privados
    public class AutomacaoCafe
    {
        public void ServirCafe()
        {
            var espresso = new CafeteiraEspressa();
            espresso.Ligar();
            espresso.PrepararCafe();
            espresso.Desligar();
        }
    }
}