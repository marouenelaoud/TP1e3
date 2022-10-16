using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp1__3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int nbEq1 = 0, nbEq2 = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ajout_Click(object sender, EventArgs e)
        {
            int ind, nb = 0;

            if (txt_eq1.Text == txt_eq2.Text)
                MessageBox.Show("Equipe 1 et Equipe 2 doivent etre differentes !!!");
            else
                if (!rdb_eq1.Checked && !rdb_eq2.Checked)

                MessageBox.Show("Vous devez choisir une equipe !!!");
            else
            {

                ind = comboBox1.SelectedIndex;

                switch (ind)
                {

                    case 0: nb = 2; break;
                    case 1: nb = 3; break;
                    case 2: nb = 3; break;
                    case 3: nb = 5; break;




                }

                if (rdb_eq1.Checked)
                {
                    list_eq1.Items.Add(comboBox1.Text);

                    nbEq1 += nb;
                }
                else
                {
                    list_eq2.Items.Add(comboBox1.Text);
                    nbEq2 += nb;
                }
            }
        }

        private void raz_Click(object sender, EventArgs e)
        {
            txt_eq1.Clear();
            txt_eq2.Clear();
            list_eq1.Items.Clear();
            list_eq2.Items.Clear();
            rdb_eq1.Checked = false;
            rdb_eq2.Checked = false;
        }

        private void res_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txt_eq1.Text + " :" + nbEq1.ToString() + "Points \n" + txt_eq2.Text + " :" + nbEq2.ToString() + "Points");
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
