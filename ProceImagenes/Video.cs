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
    public partial class Video : Form
    {
        public Video()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fotoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 prueba = new Form1();
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
