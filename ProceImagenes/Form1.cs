using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProceImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fotoToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void fotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
          
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video prueba = new Video();
            this.Hide();
            prueba.ShowDialog();
            this.Close();
        }

        private void cámaraToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
           
            Camara prueba = new Camara();

            this.Hide();
            prueba.ShowDialog();

            this.Close();
        }
    }
}
