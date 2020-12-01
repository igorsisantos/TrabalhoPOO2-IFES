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
    public class NokTu: Ofensor
    {
        private static int parteNome;
        public NokTu(String nome, int idade, double peso, int energia)
        {
            this.setNome(nome);
            this.setIdade(idade);
            this.setPeso(peso);
            this.setEnergia(energia);
            this.setNomeNacao("China");
            this.setTipo("NokTu");
        }

        public override string atacar(Guerreiro guerreiro, List<Ofensor> ofensores, List<Defensor> defensores, List<Defensor> defensoresAdversarios)
        {
            string parcial = String.Empty;
            parcial += (this.getNome() + "(" + this.getTipo() + ") ATACA!")+"\n";

            guerreiro.setEnergia(guerreiro.getEnergia() - 5);

            String nome = "mangalGerado", sobrenome;

            int idade = 30;
            double peso = 90.0;

            parteNome++;
            sobrenome = Convert.ToString(parteNome);
            nome = nome + sobrenome;

            MangalDeDefesa mangaldedefesa = new MangalDeDefesa(nome, idade, peso,100);
            defensores.Add(mangaldedefesa);
            parcial+=("Defensor gerado: " + defensores.Last().ToString())+"\n";
            parcial += ("Energia pos ataque: " + this.getEnergia()) + "\n";
            if (this.getEnergia() <= 0)
            {
                parcial +=(this.getNome() + "(" + this.getTipo() + ")" + " Morreu")+"\n";
                ofensores.Remove(this);
            }
            return parcial;
        }
    }
}
