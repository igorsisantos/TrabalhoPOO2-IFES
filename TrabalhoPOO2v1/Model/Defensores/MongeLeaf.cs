using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1.Defensores
{
    public class MongeLeaf : Defensor
    {
        public MongeLeaf(String nome, int idade, double peso, int energia)
        {
            this.setNome(nome);
            this.setIdade(idade);
            this.setPeso(peso);
            this.setEnergia(energia);
            this.setTipo("MongeLeaf");
            this.setNomeNacao("India");
        }
        public override string defender(Guerreiro guerreiro, List<Defensor> defensores, List<Ofensor> ofensores, List<Ofensor> ofensoresAdversarios)
        {
            string parcial = String.Empty;
            parcial += (this.getNome() + "(" + this.getTipo() + ") DEFENDE!") + "\n";
            if (guerreiro.getTipo().Equals("Ninja"))
            {
                this.setEnergia(0);
            }
            if (guerreiro.getTipo().Equals("ChunKu"))
            {
                this.setEnergia(0);
            }
            parcial += ("Energia pos defesa: " + this.getEnergia()) + "\n";
            if (this.getEnergia() <= 0)
            {
                parcial += (this.getNome() + "(" + this.getTipo() + ")" + " Morreu") + "\n";
                defensores.Remove(this);
            }
            return parcial;
        }
    }
}
