using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO2v1.DAO
{
    public class ImagemDAO
    {
        public string lerImagemGuerreiro(string guerreiro)
        {
            string[] imagem = Directory.GetFiles("inbox", guerreiro + ".jpg");
            return imagem.First();
        }
    }
}
