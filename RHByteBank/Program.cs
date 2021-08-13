using RHByteBank.Funcionarios;
using System;

namespace RHByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("RH-ByteBank!");
            Console.WriteLine();

            

            Console.WriteLine("=========Relação de funcionários==============");
            Console.WriteLine();

            Diretor carlos = new Diretor(5000.00, "34158792952");
            carlos.Nome = "Carlos Albuquerque";

            Console.WriteLine("Nome: " + carlos.Nome);
            Console.WriteLine("Salario: " + carlos.Salario);
            Console.WriteLine();

            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            gerenciador.Registrar(carlos);

            Console.WriteLine();

            Diretor roberta = new Diretor(10000.00, "456788321");
            roberta.Nome = "Roberta";

            gerenciador.Registrar(roberta);

            Console.WriteLine("Nome: " + roberta.Nome);
            Console.WriteLine("CPF: " + roberta.CPF);
            Console.WriteLine("Salario: " + roberta.Salario);

            Console.WriteLine();



            Console.WriteLine("=========Chamando método para aumentar Salário==============");
            Console.WriteLine();

            carlos.AumentarSalario();

            Console.WriteLine("Salario com aumento Carlos: " + carlos.Salario);

            roberta.AumentarSalario();
            Console.WriteLine("Salario com aumento Roberta: " + roberta.Salario);

            Console.WriteLine("Bonificacao Roberta: " + roberta.getBonificacao());

            Console.WriteLine("Bonificacao Carlos: " + carlos.getBonificacao());
            Console.WriteLine();

            Console.WriteLine("=========Soma bonificações e total de funcionários==============");
            Console.WriteLine();     
          

            Console.WriteLine("Total bonificações: " + gerenciador.GetTotalBonificacao());

            Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);


            Console.WriteLine("=========Autenticação parceiro comercial==============");

            ParceiroComercial parceiro = new ParceiroComercial();
            Console.WriteLine("Senha informada");
            parceiro.Senha = "123456";
            Console.WriteLine("Acesso liberado:" + parceiro.Autenticar("123456"));
            



            Console.ReadLine();

        }
    }
}
