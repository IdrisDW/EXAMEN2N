using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace v2ExamenAFactory.Forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        internal static string variableCompartida;
        private void BtnAdmin_Click(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            Form5 gm = new Form5();
            gm.Show();

            variableCompartida = "Admin";
            this.Show();
            //frm.ShowDialog();
        }

        private void Nybtn_Click(object sender, EventArgs e)
        {

        }

        private void BtnRojo_Click_1(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            Form5 gm = new Form5();
            gm.Show();
            variableCompartida = "Rojo";
            this.Show();

            //frm.ShowDialog();
        }

        private void BtnBlanco_Click_1(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            Form5 gm = new Form5();
            gm.Show();
            variableCompartida = "Blanco";
            this.Show();
            //frm.ShowDialog();
        }

        private void BtnVerde_Click_1(object sender, EventArgs e)
        {
            //Form2 frm = new Form2();
            Form5 gm = new Form5();
            gm.Show();
            variableCompartida = "Verde";
            this.Show();
            //frm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Form5 gm = new Form5();
            //gm.Show();
        }
    }
}
