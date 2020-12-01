using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.Defensores;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1.AgeOfEmpiresWar
{
    public class Batalha
    {
        private List<Ofensor> listOfensores_Atacantes;
        private List<Defensor> listOfensores_Defensores;

        private List<Ofensor> listDefensores_Atacantes;
        private List<Defensor> listDefensores_Defensor;
        
        private Ofensor ofensor;
        private Defensor defensor;
        private Nacao nacaoAtaque;
        private string resultado;
        private string andamentoResultado = String.Empty;
           
        public void setParametros(Nacao nacaoAtaque, Nacao nacaoDefesa)
        {
            this.nacaoAtaque = nacaoAtaque;
            this.ofensor = nacaoAtaque.getOfensores().First();
            this.defensor = nacaoDefesa.getDefensores().First();

            this.listOfensores_Atacantes = nacaoAtaque.getOfensores();
            this.listOfensores_Defensores = nacaoAtaque.getDefensores();
            
            this.listDefensores_Defensor = nacaoDefesa.getDefensores();
            this.listDefensores_Atacantes = nacaoDefesa.getOfensores();
        }
        public string batalha(Nacao nacao1, Nacao nacao2)
        {
            Random randNum = new Random();
            randNum.Next();
            int vezAtaque = randNum.Next(1, 3);
            int proxAtaque;
            while (nacao1.getDefensores().Count !=0 &&
                   nacao1.getOfensores().Count !=0 &&
                   nacao2.getDefensores().Count != 0 &&
                   nacao2.getOfensores().Count != 0 )
            {
                if (vezAtaque == 1)
                {
                    setParametros(nacao1,nacao2);
                    proxAtaque = 2;
                }
                else
                {
                    setParametros(nacao2,nacao1);
                    proxAtaque = 1;
                }
                while (this.defensor.getEnergia() > 0 && this.listOfensores_Atacantes.Count > 0)
                {
                    
                        andamentoResultado += this.ofensor.atacar(defensor, listOfensores_Atacantes, listOfensores_Defensores, listDefensores_Defensor);
                        andamentoResultado += this.defensor.defender(ofensor, listDefensores_Defensor, listDefensores_Atacantes, listOfensores_Atacantes);
                }
                vezAtaque = proxAtaque;
            }
            mostrarResultado(nacao1,nacao2);
            return andamentoResultado;
        }

        public string mostrarResultado(Nacao nacao1, Nacao nacao2)
        {
            var empate = 0;

            if ((nacao1.getOfensores().Count == 0 && nacao2.getDefensores().Count == 0) ||
                (nacao2.getOfensores().Count == 0 && nacao1.getDefensores().Count == 0))
            {
                resultado = "EMPATE - A PAZ REINOU" + "\n";
                empate = 1;
            }
            if (nacao1.getOfensores().Count == 0 && empate == 0)
            {
                resultado = "Vitoria Nacao "+ nacao2.getNome()+ "\n" + " - Acabaram os Atacantes da Nacao " + nacao1.getNome() +"\n";
            }
            if (nacao1.getDefensores().Count == 0 && empate == 0)
            {
                resultado = "Vitoria Nacao " + nacao2.getNome() + "\n"+ " - Acabaram os Defensores da Nacao " + nacao1.getNome() + "\n";
            }

            if (nacao2.getOfensores().Count == 0 && empate == 0)
            {
                resultado = "Vitoria Nacao " + nacao1.getNome() + "\n" + " - Acabaram os Atacantes da Nacao " + nacao2.getNome() + "\n";
            }
            if (nacao2.getDefensores().Count == 0 && empate == 0)
            {
                resultado = "Vitoria Nacao " + nacao1.getNome() + "\n" + "- Acabaram os Defensores da Nacao " + nacao2.getNome() +"\n";
            }
            return resultado;
        }

        public string getResultado()
        {
            return resultado;
        }
    }
}
