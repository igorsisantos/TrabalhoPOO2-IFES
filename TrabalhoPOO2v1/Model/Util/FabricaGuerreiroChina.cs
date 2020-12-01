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
    public class FabricaGuerreiroChina: SuperFabrica
    {
        public override void criarGuerreiro(string nome, string energia, string idade, string peso, string tipo, List<Defensor> listDefensores, List<Ofensor> listOfensores  )
        {
            if (tipo.Equals("Chun Ku"))
            {
                var guerreiro = new ChunKu(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listOfensores.Add(guerreiro);
            }
            if (tipo.Equals("Gun Te"))
            {
                var guerreiro = new GunTe(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listOfensores.Add(guerreiro);
            }
            if (tipo.Equals("Nok Tu"))
            {
                var guerreiro = new NokTu(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listOfensores.Add(guerreiro);
            }
            if (tipo.Equals("Mangal de Defesa"))
            {
                var guerreiro = new MangalDeDefesa(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
            if (tipo.Equals("Montor do Escudo"))
            {
                var guerreiro = new MontorDoEscudo(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
            if (tipo.Equals("Mirk o Conversor"))
            {
                var guerreiro = new MirkOConversor(nome, Convert.ToInt32(idade), Convert.ToDouble(peso), Convert.ToInt32(energia));
                listDefensores.Add(guerreiro);
            }
        }
    }
}
