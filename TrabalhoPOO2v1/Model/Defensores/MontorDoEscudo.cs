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
    public class MontorDoEscudo : Defensor
    {
        public MontorDoEscudo(String nome, int idade, double peso, int energia)
        {
            this.setNome(nome);
            this.setIdade(idade);
            this.setPeso(peso);
            this.setEnergia(energia);
            this.setTipo("MontorDoEscudo");
            this.setNomeNacao("China");
        }
        public override string defender(Guerreiro guerreiro, List<Defensor> defensores, List<Ofensor> ofensores, List<Ofensor> ofensoresAdversarios)
        {
            string parcial = String.Empty;
            parcial += (this.getNome() + "(" + this.getTipo() + ") DEFENDE!") + "\n";
            parcial += ("Energia pos defesa: " + this.getEnergia()) + "\n";
            if (this.getEnergia() <= 0)
            {
                parcial += (this.getNome() + "(" + this.getTipo() + ")" + " Morreu") +"\n";
                defensores.Remove(this);
                guerreiro.setEnergia(10);
            }
            return parcial;
        }
    }
}
