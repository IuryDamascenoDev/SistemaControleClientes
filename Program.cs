using System.Diagnostics.Contracts;

namespace ControleClientes
{
    class Program
    {
        static void Main(string[] args)
        {
            float Valor_Pago;
            Console.WriteLine("Informar nome: ");
            string Nome = Console.ReadLine();
            Console.WriteLine("Informar endereço ");
            string Endereco = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j)");
            string TipoPessoa = Console.ReadLine();
            if (TipoPessoa.ToLower() == "f")
            {
                PessoaFisica PF = new PessoaFisica();
                PF.Nome = Nome;
                PF.Endereco = Endereco;
                Console.WriteLine("Informar CPF");
                PF.CPF = Console.ReadLine();
                Console.WriteLine("Informar RG");
                PF.RG = Console.ReadLine();
                Console.WriteLine("Informar valor de compra");
                float Valor = float.Parse(Console.ReadLine());
                Valor_Pago = Valor;
                PF.PagarImposto(Valor_Pago);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome: " + PF.Nome);
                Console.WriteLine("Endereco: " + PF.Endereco);
                Console.WriteLine("CPF: " + PF.CPF);
                Console.WriteLine("RG: " + PF.RG);
                Console.WriteLine("Valor pago: R$" + PF.Valor);
                Console.WriteLine("Imposto: R$" + PF.ValorImposto + "(10%)");
                Console.WriteLine("Valor total: R$" + PF.Total);
            }
            else if (TipoPessoa.ToLower() == "j")
            {
                PessoaJuridica PJ = new PessoaJuridica();
                PJ.Nome = Nome;
                PJ.Endereco = Endereco;
                Console.WriteLine("Informar CNPJ");
                PJ.CNPJ = Console.ReadLine();
                Console.WriteLine("Informar IE");
                PJ.IE = Console.ReadLine();
                Console.WriteLine("Informar valor de compra");
                float Valor = float.Parse(Console.ReadLine());
                Valor_Pago = Valor;
                PJ.PagarImposto(Valor_Pago);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome: " + PJ.Nome);
                Console.WriteLine("Endereco: " + PJ.Endereco);
                Console.WriteLine("CPF: " + PJ.CNPJ);
                Console.WriteLine("RG: " + PJ.IE);
                Console.WriteLine("Valor pago: R$" + PJ.Valor);
                Console.WriteLine("Imposto: R$" + PJ.ValorImposto + "(20%)");
                Console.WriteLine("Valor total: R$" + PJ.Total);
            }

        }
    }
}