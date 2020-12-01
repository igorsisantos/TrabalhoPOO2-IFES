using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrabalhoPOO2v1.DAO;

namespace TrabalhoPOO2v1.Control
{
    public static class CtrlPrincipal
    {
        public static void iniciar()
        {
            nacao n = new nacao();
            n.Show();
        }

        public static void sobre()
        {
            SobreDAO sobre = new SobreDAO();
            sobre.abrirSobre();
        }
    }
}
