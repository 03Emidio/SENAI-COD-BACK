using System;   
namespace Atividade07
{
    class Program 
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar o Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar o Endereço");
            string var_endereco = Console.ReadLine();  
            Console.WriteLine("Pessoa Física (f) ou Jurídica (j) ");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                Pessoa_fisica pf = new Pessoa_fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar o CPF");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar o  RG");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar o valor da Compra");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_imposto(val_pag);
                Console.WriteLine("..........Pessoa Física..........");
                Console.WriteLine("Nome..........: " + pf.nome);
                Console.WriteLine("Endereço......: " + pf.endereco);
                Console.WriteLine("CPF...........: " + pf.cpf);
                Console.WriteLine("RG.............:" + pf.rg);
                Console.WriteLine("Valor da Compra " +pf.valor.ToString("C"));
                Console.WriteLine("Imposto........." + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total à Pagar..." + pf.total.ToString("C"));

            }
            if(var_tipo == "j")
            {
                Pessoa_juridica pj = new Pessoa_juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar o CNPJ");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar valor da Compra ");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_imposto(val_pag);
                Console.WriteLine("..........Pessoa Jurídica..........");
                Console.WriteLine("Nome............: " + pj.nome);
                Console.WriteLine("Endereço........: " + pj.endereco);
                Console.WriteLine("CNPJ............: " + pj.cnpj);
                Console.WriteLine("IE..............: " + pj.ie);
                Console.WriteLine("Valor da Compra.: " + pj.valor.ToString("C"));
                Console.WriteLine("Imposto.........: " + pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total............: " + pj.total.ToString("C"));



            }

        
        }



    }
}