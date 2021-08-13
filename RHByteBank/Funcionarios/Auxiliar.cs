﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RHByteBank.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public Auxiliar(double salario, string cpf) : base(2000, cpf)
        {
        }

        public override void AumentarSalario()
        {
            Salario *= 1.5;
        }

        public override double getBonificacao()
        {
            return Salario *= 0.10;
        }
    }
}
