using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoPOO2v1.DAO
{
    public class GuerreiroDAO
    {
        public struct dadosGuerreiro
        {
            public string Nome;
            public string Idade;
            public string Energia;
            public string Peso;
        }

        public dadosGuerreiro lerGuerreiroCVS(string nacao)
        {
            string[] ListFiles = Directory.GetFiles("inbox", "*.csv");
            var listImport = ListFiles.Where(s => s.Contains(nacao));
            string[] values = null;
            string[] dados = null;
            dadosGuerreiro dadosGuerreiro = new dadosGuerreiro();
            int count = 0;
            string guerreiro;
            foreach (var file in listImport)
            {
                values = File.ReadAllLines(file);
            }
            if (values != null)
            {
                count = values.Count();
                Random randNum = new Random();
                randNum.Next();
                int aleatorio = randNum.Next(0, count);
                guerreiro = values.GetValue(aleatorio).ToString();
                dados = guerreiro.Split(',');
            }
            dadosGuerreiro.Nome = dados.GetValue(0).ToString();
            dadosGuerreiro.Energia = dados.GetValue(1).ToString();
            dadosGuerreiro.Idade = dados.GetValue(2).ToString();
            dadosGuerreiro.Peso = dados.GetValue(3).ToString();
            return dadosGuerreiro;
        }
    }
}
