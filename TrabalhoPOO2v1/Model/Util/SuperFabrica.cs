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
    public abstract class SuperFabrica
    {
        public abstract void criarGuerreiro(string nome, string energia, string idade, string peso, string tipo, List<Defensor> listDefensores, List<Ofensor> listOfensores );
    }
}
