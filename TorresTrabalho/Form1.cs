using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TorresTrabalho
{
    public partial class Form1 : Form
    {
        int[,] tabuleiro = new int[3, 3];
        bool vezDoX;
        public Form1()
        {
            InitializeComponent();
            iniciaJogo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void novoJogoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iniciaJogo();
        }
        private void iniciaJogo()
        {
            button1.Text = "";
            button1.Enabled = true;
            button2.Text = "";
            button2.Enabled = true;
            button3.Text = "";
            button3.Enabled = true;
            button4.Text = "";
            button4.Enabled = true;
            button5.Text = "";
            button5.Enabled = true;
            button6.Text = "";
            button6.Enabled = true;
            button7.Text = "";
            button7.Enabled = true;
            button8.Text = "";
            button8.Enabled = true;
            button9.Text = "";
            button9.Enabled = true;
            vezDoX = true;
            label2.Text = "X";
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    tabuleiro[i, j] = -1;
                }
            }
        }

        private void atualizaJogo(int i, int j, Button b)
        {
            int valor = vezDoX ? 1 : 0;
            tabuleiro[i, j] = valor;
            string valorBotao = vezDoX ? "X" : "O";
            b.Text = valorBotao;
            b.Enabled = false;
            bool vencedor = verificaAcabou(valor);
            if (vencedor)
            {
                MessageBox.Show("O Jogador " + valorBotao + " VENCEU!");
                iniciaJogo();
                return;
            }
            bool empate = verificaEmpate();
            if (empate)
            {
                MessageBox.Show("Deu VELHA, nenhum jogador ganhou.");
                iniciaJogo();
                return;
            }
            vezDoX = !vezDoX;
            valorBotao = vezDoX ? "X" : "O";
            label2.Text = valorBotao;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            atualizaJogo(0, 0, button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            atualizaJogo(0, 1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            atualizaJogo(0, 2, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            atualizaJogo(1, 0, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            atualizaJogo(1, 1, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            atualizaJogo(1, 2, button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            atualizaJogo(2, 0, button7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            atualizaJogo(2, 1, button8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            atualizaJogo(2, 2, button9);
        }
        private bool verificaAcabou(int jogador)
        {
            for (int i = 0; i < 3; i++)
            {
                if (tabuleiro[i,0] == tabuleiro[i,1] && 
                    tabuleiro[i, 0] == tabuleiro[i, 2] &&
                    tabuleiro[i,0] == jogador)
                {
                    return true;
                }
            }
            for (int j = 0; j < 3; j++)
            {
                if (tabuleiro[0, j] == tabuleiro[1, j] &&
                    tabuleiro[0, j] == tabuleiro[2, j] &&
                    tabuleiro[0, j] == jogador)
                {
                    return true;
                }
            }
            if (tabuleiro[0, 0] == tabuleiro[1, 1] &&
                    tabuleiro[0, 0] == tabuleiro[2, 2] &&
                    tabuleiro[0, 0] == jogador)
            {
                return true;
            }
            if (tabuleiro[0, 2] == tabuleiro[1, 1] &&
                    tabuleiro[0, 2] == tabuleiro[2, 0] &&
                    tabuleiro[0, 2] == jogador)
            {
                return true;
            }
            return false;
        }

        private bool verificaEmpate()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (tabuleiro[i, j] == -1)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
