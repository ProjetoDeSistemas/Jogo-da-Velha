using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;


namespace Jogo_da_Velha
{
    
    public partial class Inicio : Form
    {
        
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 nn = new Form2();
            nn.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        

        private void Inicio_Load(object sender, EventArgs e)
        {

            SoundPlayer player = new SoundPlayer(@"C:\Jogo da Velha\Jogo da Velha\Resources\fundo.wav");

            player.PlayLooping();
           

            
           
        }
    }
}
