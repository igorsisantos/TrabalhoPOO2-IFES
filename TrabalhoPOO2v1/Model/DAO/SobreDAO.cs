using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO2v1.DAO
{
    public class SobreDAO
    {
        public void abrirSobre()
        {
            string[] caminho = Directory.GetFiles("inbox", "Sobre.pdf");
            System.Diagnostics.Process.Start(caminho.First());
        }
    }
}
