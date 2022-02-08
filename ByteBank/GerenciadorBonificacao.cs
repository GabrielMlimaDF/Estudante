using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
    public class GerenciadorBonificacao
    {
        //Recebe os valores das Bonificações
        private double _totalBonificacao;

        //Registra e soma as Bonificações
        public void Registrar(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();


        }
        //Recebe o total e retona o valor 
        public double GetTotalBonificacao()
        {
            return _totalBonificacao;
        }


    }
}
