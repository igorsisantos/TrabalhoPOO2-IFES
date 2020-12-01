using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Defensores;

namespace TrabalhoPOO2v1.Ofensores
{
    public class GunTe : Ofensor
    {
        public GunTe(String nome, int idade, double peso, int energia)
        {
            this.setNome(nome);
            this.setIdade(idade);
            this.setPeso(peso);
            this.setEnergia(energia);
            this.setNomeNacao("China");
            this.setTipo("GunTe");
        }

        public override string atacar(Guerreiro guerreiro, List<Ofensor> ofensores, List<Defensor> defensores, List<Defensor> defensoresAdversarios)
        {
            string parcial = String.Empty;
            parcial += (this.getNome() + "(" + this.getTipo() + ") ATACA!") + "\n";
            if (guerreiro.getNomeNacao().Equals("Japao"))
            {
                guerreiro.setEnergia(guerreiro.getEnergia() - 20);
            }
            if (guerreiro.getNomeNacao().Equals("India"))
            {
                guerreiro.setEnergia(guerreiro.getEnergia() - 1);
                this.setEnergia(0);
            }
            parcial +=("Energia pos ataque: " + this.getEnergia()) +"\n";
            if (this.getEnergia() <= 0)
            {
                parcial +=(this.getNome() + "(" + this.getTipo() + ")" + " Morreu") + "\n";
                ofensores.Remove(this);
            }
            return parcial;
        }
    }
}
