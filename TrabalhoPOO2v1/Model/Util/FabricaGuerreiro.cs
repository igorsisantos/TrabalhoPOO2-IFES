using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Defensores;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1.Model.Util
{
    public static class FabricaGuerreiro
    {
        public static void criarGuerreiro(string nacao, string nome, string energia, string idade, string peso, string tipo, List<Defensor>listDefensores, List<Ofensor> listOfensores )
        {
            SuperFabrica fabricaGuerreiro;
            if (nacao.Equals("Japao"))
            {
                fabricaGuerreiro = new FabricaGuerreiroJapao();
                fabricaGuerreiro.criarGuerreiro(nome, energia, idade, peso, tipo,listDefensores,listOfensores);
            }
            if (nacao.Equals("China"))
            {
                fabricaGuerreiro = new FabricaGuerreiroChina();
                fabricaGuerreiro.criarGuerreiro(nome, energia, idade, peso, tipo, listDefensores, listOfensores);
            }
            if (nacao.Equals("India"))
            {
                fabricaGuerreiro = new FabricaGuerreiroIndia();
                fabricaGuerreiro.criarGuerreiro(nome, energia, idade, peso, tipo, listDefensores, listOfensores);
            }
        }

    }
}
