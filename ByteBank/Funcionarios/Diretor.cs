using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Exempor de herança
    public class Diretor : FuncionarioAutenticavel
    {
       
       
        public Diretor(string cpf, double salario) : base(cpf, salario)
        {

            Console.WriteLine("Criando DIRETOR");
        }

        //Implementando a palavra reservada "base" que faz ref. ao que está sendo chamado
        // Exemplo chamando o GetBonificacao declarado na Class Funcionario

        public override double GetBonificacao()
        {

            return Salario + base.GetBonificacao(); 

        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

      
    }

}
