using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento
{
    public class SubCelebridade
    {
        //Todos 
        public string InfoPublic = "Tenho Instagram";

        //Herança
        protected string CorDosOlhos = "Verde";

        //Mesmo Projeto(assembly)
        internal ulong NumeroCelular = 5519999999999;

        //Herança ou msm projeto
        protected internal string JeitoDeFalar = "Muitas girias";

        //Mesma classe ou herança no msm projeto
        private protected string SegredoFamilia = "....";

        //private é padrao
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos()
        {
            Console.WriteLine("SubCelebridade ...");

            Console.WriteLine(InfoPublic); 
            Console.WriteLine(CorDosOlhos); 
            Console.WriteLine(NumeroCelular);  
            Console.WriteLine(JeitoDeFalar);   
            Console.WriteLine(SegredoFamilia);   
            Console.WriteLine(UsaMuitoPhotoshop);   

        }

    }
}
