using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoPOO2v1.AgeOfEmpiresWar
{
    public abstract class Guerreiro
    {
        private string nome { set; get; } 
        private int idade { set; get; }
        private double peso { set; get; }
        private int energia {set; get; }
        private string tipo { set; get; }
        private string nomeNacao { set; get; }

        public String getNomeNacao()
        {
            return nomeNacao;
        }

        public void setNomeNacao(String nomeNacao)
        {
            this.nomeNacao = nomeNacao;
        }
        public string getTipo()
        {
            return tipo;
        }

        public void setTipo(string tipo)
        {
            this.tipo = tipo;
        }

        public string getNome()
        {
            return nome;
        }

        public void setNome(string nome)
        {
            this.nome = nome;
        }

        public int getIdade()
        {
            return idade;
        }

        public void setIdade(int idade)
        {
            this.idade = idade;
        }

        public double getPeso()
        {
            return peso;
        }

        public void setPeso(double peso)
        {
            this.peso = peso;
        }

        public int getEnergia()
        {
            return energia;
        }

        public void setEnergia(int energia)
        {
            this.energia = energia;
        }

    }
}
