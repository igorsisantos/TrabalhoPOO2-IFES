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
    public class FabricaGuerreiroIndia: SuperFabrica
    {
        public override void criarGuerreiro(string nome, string energia, string idade, string peso, string tipo, List<Defensor> listDefensores, List<Ofensor> listOfensores  )
        {
            if (tipo.Equals("Seak"))
            {
                var guerreiro = new Seak(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listOfensores.Add(guerreiro);
            }
            if (tipo.Equals("Monge Leaf"))
            {
                var guerreiro = new MongeLeaf(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
            if (tipo.Equals("Monge Bomb"))
            {
                var guerreiro = new MongeBomb(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
            if (tipo.Equals("Monge Barrier"))
            {
                var guerreiro = new MongeBarrier(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
        }
    }
}
