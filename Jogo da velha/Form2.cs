using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Jogo_da_Velha
{
    public partial class Form2 : Form
    {
        public int r1, r2, r3, r4, r5, r6, r7, r8, r9;
        public int i;
        public int contador = 0, contador1 = 0, contador2 = 0;
        public void limpar()
        {
            bt_1.Visible = true;
            bt_2.Visible = true;
            bt_3.Visible = true;
            bt_4.Visible = true;
            bt_5.Visible = true;
            bt_6.Visible = true;
            bt_7.Visible = true;
            bt_8.Visible = true;
            bt_9.Visible = true;
            r1 = 0;
            r2 = 0;
            r3 = 0;
            r4 = 0;
            r5 = 0;
            r6 = 0;
            r7 = 0;
            r8 = 0;
            r9 = 0;

        }
        public void fechar()
        {
            i = 1;
        }
        public void pontuacao()
        {
            contador = contador + 1;
            label6.Text =Convert.ToString(contador);
        }
        public void pontuacao1()
        {
            contador1 = contador1 + 1;
            label7.Text = Convert.ToString(contador1);
        }
        public void velha()
        {
            contador2 = contador2 + 1;
            label8.Text = Convert.ToString(contador2);

        }
        public void verificar()
        {
            if (r1 == 1 && r2 == 2 && r3 == 3)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
                
               
            }
            if (r4 == 4 && r5 == 5 && r6 == 6)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();

            }
            if (r7 == 7 && r8 == 8 && r9 == 9)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 1 && r4 == 4 && r7 == 7)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r2 == 2 && r5 == 5 && r8 == 8)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 3 && r6 == 6 && r9 == 9)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 1 && r5 == 5 && r9 == 9)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 3 && r5 == 5 && r7 == 7)
            {
                MessageBox.Show("Jogador Um é o vencedor");
                pontuacao();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 11 && r2 == 12 && r3 == 13)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r4 == 14 && r5 == 15 && r6 == 16)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r7 == 17 && r8 == 18 && r9 == 19)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 11 && r4 == 14 && r7 == 17)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r2 == 12 && r5 == 15 && r8 == 18)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 13 && r6 == 16 && r9 == 19)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r1 == 11 && r5 == 15 && r9 == 19)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (r3 == 13 && r5 == 15 && r7 == 17)
            {
                MessageBox.Show("Jogador Dois é o vencedor");
                pontuacao1();
                limpar();
                labecorrecao();
                fechar();
            }
            if (i == 10)
            {
                MessageBox.Show("Deu velha");
                velha();
                limpar();
                labecorrecao();
                fechar();
            }
        }
        public Form2()
        {
            InitializeComponent();
            i = 1;
            
        }
        private void bt_1_Click(object sender, EventArgs e)
        {
            bt_1.Visible = false;
            if (i % 2 == 1)
            {
                r1 = 1;
                pb_1.Image = Properties.Resources.x__1_;
                i = i + 1;
                label2.Visible = true;
                label1.Visible = false;
                verificar();
            }
            else
            {
                r1 = 11;
                pb_1.Image = Properties.Resources.o;
                i = i + 1;
                label2.Visible = false;
                label1.Visible = true;
                verificar();
            }

        }
        public void labe()
        {
            label2.Visible = true;
            label1.Visible = false;
        }
        public void labe1()
        {
            label2.Visible = false;
            label1.Visible = true;
        }
        public void labecorrecao()
        {
            label1.Visible = true;
            label2.Visible = false;
        }
        private void bt_2_Click(object sender, EventArgs e)
        {
            bt_2.Visible = false;
            if (i % 2 == 1)
            {
                r2 = 2;
                pb_2.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r2 = 12;
                pb_2.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            bt_3.Visible = false;
            if (i % 2 == 1)
            {
                r3 = 3;
                pb_3.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r3 = 13;
                pb_3.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            bt_4.Visible = false;
            if (i % 2 == 1)
            {
                r4 = 4;
                pb_4.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r4 = 14;
                pb_4.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            bt_5.Visible = false;
            if (i % 2 == 1)
            {
                r5 = 5;
                pb_5.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r5 = 15;
                pb_5.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            bt_6.Visible = false;
            if (i % 2 == 1)
            {
                r6 = 6;
                pb_6.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r6 = 16;
                pb_6.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            bt_7.Visible = false;
            if (i % 2 == 1)
            {
                r7 = 7;
                pb_7.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r7 = 17;
                pb_7.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            bt_8.Visible = false;
            if (i % 2 == 1)
            {
                r8 = 8;
                pb_8.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r8 = 18;
                pb_8.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            bt_9.Visible = false;
            if (i % 2 == 1)
            {
                r9 = 9;
                pb_9.Image = Properties.Resources.x__1_;
                i = i + 1;
                labe();
                verificar();
            }
            else
            {
                r9 = 19;
                pb_9.Image = Properties.Resources.o;
                i = i + 1;
                labe1();
                verificar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pb_1_Click(object sender, EventArgs e)
        {

        }

        private void pb_2_Click(object sender, EventArgs e)
        {

        }

        private void pb_3_Click(object sender, EventArgs e)
        {

        }

        private void pb_4_Click(object sender, EventArgs e)
        {

        }

        private void pb_5_Click(object sender, EventArgs e)
        {

        }

        private void pb_6_Click(object sender, EventArgs e)
        {

        }

        private void pb_7_Click(object sender, EventArgs e)
        {

        }

        private void pb_8_Click(object sender, EventArgs e)
        {

        }

        private void pb_9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
