using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Defensores;

namespace TrabalhoPOO2v1.Ofensores
{
    public abstract class Ofensor : Guerreiro
    {
        public abstract string atacar(Guerreiro guerreiro, List<Ofensor> ofensores, List<Defensor> defensores, List<Defensor> defensoresAdversarios);
    }
}
