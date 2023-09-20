namespace ControleClientes
{
    public class PessoaJuridica : Cliente
    {
        public string CNPJ { get; set; }
        public string IE { get; set; }

        public override void PagarImposto(float v)
        {
            this.Valor = v;
            this.ValorImposto = this.Valor * 20 / 100;
            this.Total = this.Valor + this.ValorImposto;
        }
    }
}