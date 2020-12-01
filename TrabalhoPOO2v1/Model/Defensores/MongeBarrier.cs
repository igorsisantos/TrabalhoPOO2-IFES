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
    public class MongeBarrier: Defensor
    {
        private static int parteNome;

        public MongeBarrier(String nome, int idade, double peso, int energia)
        {
            this.setNome(nome);
            this.setIdade(idade);
            this.setPeso(peso);
            this.setEnergia(energia);
            this.setTipo("MongeBarrier");
            this.setNomeNacao("India");
        }
        public static int getParteNome()
        {
            return parteNome;
        }

        public static void setParteNome(int parteNome)
        {
            MongeBarrier.parteNome = parteNome;
        }

        public override string defender(Guerreiro guerreiro, List<Defensor> defensores, List<Ofensor> ofensores, List<Ofensor> ofensoresAdversarios)
        {
            string parcial = String.Empty;
            parcial += (this.getNome() + "(" + this.getTipo() + ") DEFENDE!") +"\n";     
            if ((this.getEnergia() <= 0))
            {
                for (int i = 0; i < 2; i++)
                {
                    String nome = "MongeBarrierGerado", sobrenome;
                    parteNome++;
                    sobrenome = Convert.ToString(parteNome);
                    nome = nome + sobrenome;
                    MongeBarrier mongebarrier = new MongeBarrier(nome, this.getIdade(), this.getPeso(), this.getEnergia());
                    mongebarrier.setEnergia(200);
                    defensores.Add(mongebarrier);
                    parcial+= ("Monge Barrier gerado: " + nome + "\n");
                }
                parcial += (this.getNome() + "(" + this.getTipo() + ")" + " Morreu") +"\n";
                defensores.Remove(this);      
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
