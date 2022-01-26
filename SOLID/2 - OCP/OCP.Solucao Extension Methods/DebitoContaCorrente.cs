namespace SOLID.OCP.Solucao_Extension_Methods
{
    // ! Classe e métodos precisam ser estaticos!
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // Logica de negócio para debito em conta corrente.
            return debitoConta.FormatarTransacao();
        }
    }
}