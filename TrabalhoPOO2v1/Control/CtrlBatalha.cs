using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.AgeOfEmpiresWar;

namespace TrabalhoPOO2v1.Control
{
    public static class CtrlBatalha
    {
        public static void preencheListView(ListView listView, ListView listView2, Nacao nacao)
        {
            foreach (var ofensores in nacao.getOfensores().ToList())
            {
                ListViewItem objListViewItem = new ListViewItem { Text = ofensores.getNome() };
                objListViewItem.SubItems.Add(ofensores.getEnergia().ToString());
                objListViewItem.SubItems.Add(ofensores.getTipo());
                listView.Items.Add(objListViewItem);
            }
            foreach (var defensores in nacao.getDefensores().ToList())
            {
                ListViewItem objListViewItem = new ListViewItem { Text = defensores.getNome() };
                objListViewItem.SubItems.Add(defensores.getEnergia().ToString());
                objListViewItem.SubItems.Add(defensores.getTipo());
                listView2.Items.Add(objListViewItem);
            }
        }
        public static void imprimirResultadoFinal(Label lblResultadoFinal, Button btnSalvar, ListView listFinal, String[] resultadoFinal)
        {
            lblResultadoFinal.Visible = true;
            btnSalvar.Visible = true;
            listFinal.Visible = true;
            foreach (var step in resultadoFinal.ToList())
            {
                ListViewItem objListViewItem = new ListViewItem { Text = step };
                listFinal.Items.Add(objListViewItem);
                listFinal.Refresh();
            }
        }
        public static void imprimir(ListView listResultado, String[] passoAndamento)
        {
            foreach (var step in passoAndamento.ToList())
            {
                ListViewItem objListViewItem = new ListViewItem { Text = step };
                listResultado.Items.Add(objListViewItem);
                listResultado.Refresh();
                listResultado.EnsureVisible(listResultado.Items.Count - 1);
                Thread.Sleep(1000);
            }
        }
    }
}
