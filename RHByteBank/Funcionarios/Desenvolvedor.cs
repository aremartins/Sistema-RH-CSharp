using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHByteBank.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(double salario, string cpf) : base(salario, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 0.15;
        }

        public override double getBonificacao()
        {
            return Salario *= 0.1;
        }
    }
}
