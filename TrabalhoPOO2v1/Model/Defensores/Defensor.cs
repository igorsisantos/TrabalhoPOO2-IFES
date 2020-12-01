using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1.Defensores
{
    public abstract class Defensor : Guerreiro
    {
        public abstract string defender(Guerreiro guerreiro, List<Defensor> defensores, List<Ofensor> ofensores, List<Ofensor> ofensoresAdversarios);
    }
}
