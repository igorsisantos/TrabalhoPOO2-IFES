using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.Defensores;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1.AgeOfEmpiresWar
{
    public class Nacao
    {
        private List<Defensor> listDefensores;
        private List<Ofensor> listOfensores;
        private string nome;
        public Nacao()
        {
        }

        public List<Ofensor> getOfensores()
        {
            return listOfensores;
        }
        public List<Defensor> getDefensores()
        {
            return listDefensores;
        }

        public void setNome(string nome2)
        {
            this.nome = nome2;
        }
        public void setOfensores(List<Ofensor> listOfensores )
        {
            this.listOfensores = listOfensores;
        }
        public void setDefensores(List<Defensor> listDefensores)
        {
            this.listDefensores = listDefensores;
        }

        public string getNome()
        {
            return nome;
        }
    }
}
