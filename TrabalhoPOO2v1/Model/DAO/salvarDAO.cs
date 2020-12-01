using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.AgeOfEmpiresWar;

namespace TrabalhoPOO2v1.Model.DAO
{
    public class SalvarDAO
    {
        public void salvar(Nacao n1, Nacao n2, String[] resultadoFinal, SaveFileDialog saveFileDialog1)
        {
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo Texto";
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.txt";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0;
            //Atribui um valor vazio ao nome do arquivo
            saveFileDialog1.FileName = "Relatório_" + DateTime.Now.ToString("dd-MM-yyyy_HH-mm");
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".txt";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\";
            //restaura o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;
            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();

            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                //Cria um stream usando o nome do arquivo
                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
                //Cria um escrito que irá escrever no stream
                StreamWriter writer = new StreamWriter(fs);
                writer.WriteLine(n1.getNome() + "\n");
                writer.WriteLine("\n");
                writer.WriteLine("Lista Ofensores \n");
                writer.WriteLine("\n");
                foreach (var escrever in n1.getOfensores().ToList())
                {
                    writer.WriteLine(escrever.getNome() + " " + escrever.getEnergia() + " " + escrever.getTipo() + "\n");
                }
                writer.WriteLine("\n");
                writer.WriteLine("Lista Defensores \n");
                writer.WriteLine("\n");
                foreach (var escrever in n1.getDefensores().ToList())
                {
                    writer.WriteLine(escrever.getNome() + " " + escrever.getEnergia() + " " + escrever.getTipo() + "\n");
                }
                writer.WriteLine("\n");
                writer.WriteLine(n2.getNome() + "\n");
                writer.WriteLine("\n");
                writer.WriteLine("Lista Ofensores \n");
                writer.WriteLine("\n");
                foreach (var escrever in n2.getOfensores().ToList())
                {
                    writer.WriteLine(escrever.getNome() + " " + escrever.getEnergia() + " " + escrever.getTipo() + "\n");
                }
                writer.WriteLine("\n");
                writer.WriteLine("Lista Defensores \n");
                writer.WriteLine("\n");
                foreach (var escrever in n2.getDefensores().ToList())
                {
                    writer.WriteLine(escrever.getNome() + " " + escrever.getEnergia() + " " + escrever.getTipo() + "\n");
                }
                writer.WriteLine("\n");
                foreach (var escrever in resultadoFinal.ToList())
                {
                    writer.WriteLine(escrever + "\n");
                }
                writer.Close();
            }
            else
            {
                MessageBox.Show("Operação cancelada");
            }
        }
    }
}
