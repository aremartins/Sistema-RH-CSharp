using RHByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHByteBank.Funcionarios
{
    public class GerenteConta : FuncionarioAutenticavel

    {
        public GerenteConta(double salario, string cpf) : base(4000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        public override double getBonificacao()
        {
            return Salario *= 0.25;
        }




    }
}
