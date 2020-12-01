using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Defensores;
using TrabalhoPOO2v1.Model.Util;
using TrabalhoPOO2v1.Ofensores;
using colAlias = System.Collections;

namespace TrabalhoPOO2v1
{
    public class CtrlNacao
    {
        private static List<Nacao> nacoes = new List<Nacao>();
        public void criarNacao(String nomeNacao)
        {
            guerreiro g = new guerreiro();
            g.tipoNacao = nomeNacao;
            g.ShowDialog();
            if (g.listDefensores.Count > 0 && g.listOfensores.Count > 0)
            {
                NacaoAbstractBuilder builder;
                var director = new Director();
                builder = new NacaoBuilder(g.tipoNacao, g.listDefensores, g.listOfensores);
                director.construct(builder);
                nacoes.Add(builder.Nacao);
            }
        }

        public static bool controlarDuasNacoes()
        {
            if (nacoes.Count == 2)
            {
                batalha b = new batalha(nacoes[0], nacoes[1]);
                b.Show();
                nacoes.Clear();
                return true;
            }
            return false;
        }

    }
}
