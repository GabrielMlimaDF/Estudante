using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Exempor de herança
    public class GerenteDeconta : FuncionarioAutenticavel
    {
        public GerenteDeconta(string cpf) : base(cpf,4000)
        {
        }

        //Implementando a palavra reservada "base" que faz ref. ao que está sendo chamado
        // Exemplo chamando o GetBonificacao declarado na Class Funcionario

        public override double GetBonificacao()
        {

            return Salario *= 0.25; 

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }


    }

}
