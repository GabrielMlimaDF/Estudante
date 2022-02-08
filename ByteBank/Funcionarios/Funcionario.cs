using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    //Tornando a class Funcionario Abstrata, ou seja, ela não poderá ser instanciada
    //servirá apenas como base
    public abstract class Funcionario
    {
        //0 - Funcionário sem definição
        //1 - Diretor
        //2 - Designer
        //n - ...


        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; set; }
        public string CPF { get; private set; }

        //Tornando o Salário protegido, mas acessível para bases filhos
        public double Salario { get; protected set; }


        //Totalizando funcionários que passam na INSTANCIA
        public Funcionario(string cpf, double salario)
        {
            Console.WriteLine("Criando...");
            TotalDeFuncionarios++;

            CPF = cpf;
            Salario = salario;

        }

      

        public virtual void AumentarSalario()
        {
            Salario *= 1.1;
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;

        }

    }
}
