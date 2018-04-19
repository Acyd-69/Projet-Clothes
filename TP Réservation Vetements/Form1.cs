using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Réservation_Vetements
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

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Tshirt_Homme.jpg";
        }

        private void vestesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Veste_Homme.jpg";
        }

        private void pantalonJeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Pantalon_Homme.jpg";
        }

        private void chaussuresBasketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Chaussure_Homme.jpg";
        }

        private void tShirtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Tshirt_Femme.jpg";
        }

        private void vestesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Veste_Femme.jpg";
        }

        private void pantalonJeansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Pantalon_Femme.jpg";
        }

        private void chaussuresBasketsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Chaussure_Femme.jpg";
        }
    }
}
