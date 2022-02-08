using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

          //CalcularBonificacao();
            UsarSistema();

            Console.ReadLine();

           

            
        }


        public static void UsarSistema()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            Diretor roberta = new Diretor("833.222.048-39",5000);
            roberta.Nome = "Roberta";
            roberta.Senha = "123";


           
            ParceiroComercial jonas = new ParceiroComercial();
            jonas.Senha = "12345";


            Console.WriteLine(roberta.Nome);
                sistemaInterno.Logar(roberta, "123");
            sistemaInterno.Logar(jonas, "1230");
            

        }



        //Método colocado fora do MAIN precisa ser Static porque o MAIN é static
        public static void CalcularBonificacao()
        {

            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("833.222.048-39");
            pedro.Nome = "Pedro";

            Diretor roberta = new Diretor("854.658.698-40",5000);
            roberta.Nome = "Roberta";
            

            Auxiliar igor = new Auxiliar("833.222.048-39");
            igor.Nome = "Igor";
            

            GerenteDeconta camila = new GerenteDeconta("833.222.048-39");
            camila.Nome = "Camila";


            gerenciadorBonificacao.Registrar(pedro);
            gerenciadorBonificacao.Registrar(roberta);
            gerenciadorBonificacao.Registrar(igor);
            gerenciadorBonificacao.Registrar(camila);

            Console.WriteLine("Total de bonificação do mês R$ " + gerenciadorBonificacao.GetTotalBonificacao());


        }

    }
}
