using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.AgeOfEmpiresWar;

namespace TrabalhoPOO2v1.Model.Util
{
    //builder abstrato
    public abstract class NacaoAbstractBuilder
    {
        protected Nacao nacao;
        public Nacao Nacao
        {
            get { return nacao; }
        }
        //processo de construção abstrato
        public abstract void buildNome();
        public abstract void buildListDefensores();
        public abstract void buildListOfensores();

    }

}
