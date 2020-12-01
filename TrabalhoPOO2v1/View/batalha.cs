using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using TrabalhoPOO2v1.AgeOfEmpiresWar;
using TrabalhoPOO2v1.Control;
using TrabalhoPOO2v1.Model.DAO;

namespace TrabalhoPOO2v1
{
    public partial class batalha : Form
    {
        private Nacao n1;
        private Nacao n2;
        private string passo = String.Empty;
        private string [] passoAndamento;
        private string resultado;
        private string[] resultadoFinal;
        public batalha(Nacao nacao1, Nacao nacao2)
        {
            this.n1 = nacao1;
            this.n2 = nacao2;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            Batalha batalha = new Batalha();
            passo = batalha.batalha(n1,n2);
            passoAndamento = passo.Split('\n');
            CtrlBatalha.imprimir(listResultado, passoAndamento);
            resultado = batalha.getResultado();
            resultadoFinal = resultado.Split('\n');
            CtrlBatalha.imprimirResultadoFinal(lblResultadoFinal, btnSalvar, listFinal, resultadoFinal);
        }

        private void batalha_Load(object sender, EventArgs e)
        {
            txtNacao1.Text = n1.getNome();
            txtNacao2.Text = n2.getNome();
            CtrlBatalha.preencheListView(listViewOfensores1,listViewDefensores1,n1);
            CtrlBatalha.preencheListView(listViewOfensores2,listViewDefensores2,n2);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            SalvarDAO salvar = new SalvarDAO();
            salvar.salvar(n1,n2,resultadoFinal,saveFileDialog1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
