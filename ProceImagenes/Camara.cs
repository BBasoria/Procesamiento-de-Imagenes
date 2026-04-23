using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using AForge.Video;
using AForge.Video.DirectShow;


namespace ProceImagenes
{
    public partial class Camara : Form
    {
        public Camara()
        {
            InitializeComponent();
        }

        private void Camara_Load(object sender, EventArgs e)
        {

        }

        private void fotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 prueba = new Form1();
            this.Hide();
            prueba.ShowDialog();
            this.Close();
        }

        private void videoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Video prueba = new Video();
            this.Hide();
            prueba.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Camara_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
