using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabalhoPOO2v1.Control;
using TrabalhoPOO2v1.DAO;
using TrabalhoPOO2v1.Defensores;
using TrabalhoPOO2v1.Ofensores;

namespace TrabalhoPOO2v1
{
    public partial class guerreiro : Form
    {
        public bool pronto;
        public string tipoNacao;
        public List<Ofensor> listOfensores;
        public List<Defensor> listDefensores;

        public guerreiro()
        {
            listDefensores= new List<Defensor>();
            listOfensores= new List<Ofensor>();
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void guerreiro_Load(object sender, EventArgs e)
        {
            btnNacaoPronta.Enabled = false;
            carregarComboBox(tipoNacao);
            comboBox1.SelectedIndex = 0;
        }

        private void carregarComboBox(string tipo)
        {
            if (tipo.Equals("Japao"))
            {
                comboBox1.Items.Add("Samurai");
                comboBox1.Items.Add("Ninja");
                comboBox1.Items.Add("Tan tan");
                
            }
            if (tipo.Equals("China"))
            {
                comboBox1.Items.Add("Chun Ku");
                comboBox1.Items.Add("Gun Te");
                comboBox1.Items.Add("Nok Tu");
                comboBox1.Items.Add("Mangal de Defesa");
                comboBox1.Items.Add("Montor do Escudo");
                comboBox1.Items.Add("Mirk o Conversor");
            }
            if (tipo.Equals("India"))
            {
                comboBox1.Items.Add("Seak");
                comboBox1.Items.Add("Monge Leaf");
                comboBox1.Items.Add("Monge Bomb");
                comboBox1.Items.Add("Monge Barrier");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && !string.IsNullOrEmpty(txtEnergia.Text) &&
                !string.IsNullOrEmpty(txtIdade.Text) && !string.IsNullOrEmpty(txtPeso.Text) &&
                !string.IsNullOrEmpty(comboBox1.Text))
            {
                CtrlGuerreiro.guerreiro(tipoNacao, txtNome.Text, txtEnergia.Text, txtIdade.Text, txtPeso.Text, comboBox1.Text,listDefensores,listOfensores);
                adicionarListView();
                checkBox1.Checked = false;
            }
            if (listDefensores.Count > 0 && listOfensores.Count > 0)
            {
                btnNacaoPronta.Enabled = true;
            }
        }
        private void adicionarListView()
        {
            var objListViewItem = new ListViewItem { Text = txtNome.Text };
            objListViewItem.SubItems.Add(txtEnergia.Text);
            objListViewItem.SubItems.Add(comboBox1.Text);
            listView1.Items.Add(objListViewItem);
            txtNome.Clear();
            txtEnergia.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            txtNome.Focus();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {              
                GuerreiroDAO.dadosGuerreiro dados = CtrlGuerreiro.carregarGuerreiro(tipoNacao);
                txtNome.Text = dados.Nome;
                txtEnergia.Text = dados.Energia;
                txtIdade.Text = dados.Idade;
                txtPeso.Text = dados.Peso;
                
            }
            else
            {
                txtNome.Clear();
                txtEnergia.Clear();
                txtIdade.Clear();
                txtPeso.Clear();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CtrlGuerreiro.carregarImagem(comboBox1,pictureBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEnergia.Clear();
            txtIdade.Clear();
            txtPeso.Clear();
            checkBox1.Checked = false;
        }
    }
}
