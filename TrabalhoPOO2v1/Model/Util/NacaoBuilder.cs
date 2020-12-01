using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.AgeOfEmpiresWar;

namespace TrabalhoPOO2v1.Model.Util
{
    public class NacaoBuilder : NacaoAbstractBuilder
    {
        public string nome;
        public List<Defensores.Defensor> listDefensores;
        public List<Ofensores.Ofensor> listOfensores;

        public NacaoBuilder(string nome, List<Defensores.Defensor> listDefensores, List<Ofensores.Ofensor> listOfensores)
        {
            nacao = new Nacao();
            this.nome = nome;
            this.listDefensores = listDefensores;
            this.listOfensores = listOfensores;

        }
        public override void buildNome()
        {
            nacao.setNome(nome);
        }

        public override void buildListDefensores()
        {
            nacao.setDefensores(listDefensores);
        }

        public override void buildListOfensores()
        {
            nacao.setOfensores(listOfensores);
        }
    }
}
