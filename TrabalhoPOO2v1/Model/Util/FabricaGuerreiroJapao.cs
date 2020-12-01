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
    public class FabricaGuerreiroJapao: SuperFabrica
    {
        public override void criarGuerreiro(string nome, string energia, string idade, string peso, string tipo, List<Defensor> listDefensores, List<Ofensor> listOfensores )
        {
            if (tipo.Equals("Samurai"))
            {
                var guerreiro = new Samurai(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listOfensores.Add(guerreiro);
            }
            if (tipo.Equals("Ninja"))
            {
                var guerreiro = new Ninja(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listOfensores.Add(guerreiro);
            }
            if (tipo.Equals("Tan tan"))
            {
                var guerreiro = new TanTan(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
        }
    }
}
