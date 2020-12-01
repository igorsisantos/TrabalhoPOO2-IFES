using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoPOO2v1.Control;
using TrabalhoPOO2v1.DAO;

namespace TrabalhoPOO2v1
{
    public partial class principal : Form
    {
        private static principal singletonPrincipal;
        public principal()
        {
            InitializeComponent();
        }
        public static principal Instance()
        {
            if (singletonPrincipal == null)
            {
                singletonPrincipal = new principal();
            }
            return singletonPrincipal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CtrlPrincipal.iniciar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void principal_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           CtrlPrincipal.sobre();
        }
    }
}
