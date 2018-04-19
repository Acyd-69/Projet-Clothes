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
        public bool Tshirt_Homme;
        public bool Veste_Homme;
        public bool Pantalon_Homme;
        public bool Chaussure_Homme;

        public bool Tshirt_Femme;
        public bool Veste_Femme;
        public bool Pantalon_Femme;
        public bool Chaussure_Femme;

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
            this.Tshirt_Homme = true;
        }

        private void vestesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Veste_Homme.jpg";
            this.Veste_Homme = true;
        }

        private void pantalonJeansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Pantalon_Homme.jpg";
            this.Pantalon_Homme = true;
        }

        private void chaussuresBasketsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Chaussure_Homme.jpg";
            this.Chaussure_Homme = true;
        }

        private void tShirtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Tshirt_Femme.jpg";
            this.Tshirt_Femme = true;
        }

        private void vestesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Veste_Femme.jpg";
            this.Veste_Femme = true;
        }

        private void pantalonJeansToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Pantalon_Femme.jpg";
            this.Pantalon_Femme = true;
        }

        private void chaussuresBasketsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.pictureBox1.ImageLocation = "C:/Users/Delphine/Documents/Tp_Visual_Studio/TP_Réservation_Vetements/Images/Chaussure_Femme.jpg";
            this.Chaussure_Femme = true;
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked && Tshirt_Homme)
            {
                this.dataGridView1.Rows.Add("Tshirt Homme", this.comboBox1.SelectedItem.ToString() );
            }
            Tshirt_Homme = false;

            if(checkBox1.Checked && Veste_Homme)
            {
                this.dataGridView1.Rows.Add("Veste Homme", this.comboBox1.SelectedItem.ToString() );
            }
            Veste_Homme = false;
            
            if(checkBox1.Checked && Pantalon_Homme)
            {
                this.dataGridView1.Rows.Add("Pantalon Homme", this.comboBox1.SelectedItem.ToString() );
            }
            Pantalon_Homme = false;

            if(checkBox1.Checked && Chaussure_Homme)
            {
                this.dataGridView1.Rows.Add("Chaussure Homme", this.comboBox1.SelectedItem.ToString() ) ;
            }
            Chaussure_Homme = false;

            // Partie Femme

            if(checkBox1.Checked && Tshirt_Femme)
            {
                this.dataGridView1.Rows.Add("Tshirt Femme", this.comboBox1.SelectedItem.ToString() );
            }
            Tshirt_Femme = false;

            if(checkBox1.Checked && Veste_Femme)
            {
                this.dataGridView1.Rows.Add("Veste Femme", this.comboBox1.SelectedItem.ToString() );
            }
            Veste_Femme = false;

            if(checkBox1.Checked && Pantalon_Femme)
            {
                this.dataGridView1.Rows.Add("Pantalon Femme", this.comboBox1.SelectedItem.ToString() ) ;
            }
            Pantalon_Femme = false;

            if(checkBox1.Checked && Chaussure_Femme)
            {
                this.dataGridView1.Rows.Add("Chaussure Femme", this.comboBox1.SelectedItem.ToString() );
            }
            Chaussure_Femme = false;
        }
    }
}
