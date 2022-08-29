using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoQuiz
{
    class Respostas
    {

        public static int acerto = 0;
        public static int erro = 0;
        public void Reposta(int verif)
        {
            if (verif == 1)
                acerto++;
            else
                erro++;  
        }

        public static int getAcertos()
        {
            return acerto;
        }
        public static int getErros()
        {
            return erro;
        }
    }
}
