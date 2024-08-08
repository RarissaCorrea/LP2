using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado //especializado -->herança
    {

        
        public Double SalarioMensal { get; set; }



        //sobreescrevendo o metodo
        public override double SalarioBruto()
        {
            return SalarioMensal;

        }

        //construtor --> new

    }
}
