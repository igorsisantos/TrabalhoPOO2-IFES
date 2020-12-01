using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO2v1.Model.Util
{
    public class Director
    {
        public void construct(NacaoAbstractBuilder builder)
        {
            builder.buildNome();
            builder.buildListDefensores();
            builder.buildListOfensores();
        }
    }
}
