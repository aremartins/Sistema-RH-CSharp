using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHByteBank.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(double salario, string cpf) : base(3000, cpf)
        {
        }


        public override double getBonificacao()
        {
            return Salario *= 1.11;
        }

        public override void AumentarSalario()
        {
            Salario *= 0.17;
        }
    }
}
