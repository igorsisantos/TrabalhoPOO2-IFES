using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.DAO;
using TrabalhoPOO2v1.Defensores;
using TrabalhoPOO2v1.Model.Util;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1.Control
{
    public static class CtrlGuerreiro
    {
        public static void carregarImagem(ComboBox comboBox1, PictureBox pictureBox1)
        {
            ImagemDAO caminho = new ImagemDAO();
            pictureBox1.ImageLocation = caminho.lerImagemGuerreiro(comboBox1.Text);
        }

        public static GuerreiroDAO.dadosGuerreiro carregarGuerreiro(string tipoNacao)
        {
            GuerreiroDAO guerreiro = new GuerreiroDAO();
            return guerreiro.lerGuerreiroCVS(tipoNacao);
        }

        public static void guerreiro(string nacao, string nome, string energia, string idade, string peso, string tipo, List<Defensor> listDefensores, List<Ofensor> listOfensores)
        {
            FabricaGuerreiro.criarGuerreiro(nacao, nome, energia, idade, peso, tipo, listDefensores, listOfensores);
        }
    }
}
