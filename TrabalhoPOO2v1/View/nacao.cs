using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Control;


namespace TrabalhoPOO2v1
{
    public partial class nacao : Form
    {
        private CtrlNacao ctrlnacao;
        public nacao()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ctrlnacao.criarNacao("Japao");  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ctrlnacao.criarNacao("India");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ctrlnacao.criarNacao("China");
        }

        private void nacao_Load(object sender, EventArgs e)
        {
            ctrlnacao = new CtrlNacao();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CtrlNacao.controlarDuasNacoes())
            {
                Close();
            }
            else
            {
                MessageBox.Show(@"Favor Informar nações!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
