using RHByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHByteBank.Funcionarios
{
    public class Diretor : FuncionarioAutenticavel

    {
        
        public Diretor(double salario, string cpf): base(5000, cpf)
        {

        }

        public override double getBonificacao()
        {
            return Salario + base.getBonificacao();
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}
